using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    /// <summary>Connection to the Access database. Creates the file and tables on first run.</summary>
    public static class Database
    {
        // Tried in this order; the first one installed on the computer is used.
        private static readonly string[] Providers =
        {
            "Microsoft.ACE.OLEDB.16.0",
            "Microsoft.ACE.OLEDB.12.0"
        };

        private static string _connectionString;

        public static string FilePath
        {
            get { return Path.Combine(Application.StartupPath, "InventoryDB.accdb"); }
        }

        public static OleDbConnection Open()
        {
            if (_connectionString == null) Initialize();
            var conn = new OleDbConnection(_connectionString);
            conn.Open();
            return conn;
        }

        public static void Initialize()
        {
            Exception last = null;

            foreach (string provider in Providers)
            {
                string cs = "Provider=" + provider + ";Data Source=" + FilePath + ";";
                try
                {
                    if (!File.Exists(FilePath)) CreateFile(cs);

                    using (var test = new OleDbConnection(cs))
                        test.Open();

                    _connectionString = cs;
                    EnsureTables();
                    return;
                }
                catch (Exception ex)
                {
                    last = ex;
                }
            }

            throw new InvalidOperationException(
                "Could not open the Access database.\n\n" +
                "Install the Microsoft Access Database Engine (ACE OLEDB). If it is already installed, " +
                "set the project's Platform target (Project > Properties > Build) to x86 or x64 " +
                "so it matches the installed engine.\n\nDetails: " +
                (last != null ? last.Message : "unknown error"));
        }

        // Creates an empty .accdb using ADOX (comes with the Access engine)
        private static void CreateFile(string connectionString)
        {
            Type t = Type.GetTypeFromProgID("ADOX.Catalog");
            if (t == null) throw new InvalidOperationException("ADOX is not available.");

            object catalog = Activator.CreateInstance(t);
            try
            {
                t.InvokeMember("Create", BindingFlags.InvokeMethod, null, catalog, new object[] { connectionString });
            }
            finally
            {
                Marshal.ReleaseComObject(catalog);
            }
        }

        private static void EnsureTables()
        {
            using (var conn = new OleDbConnection(_connectionString))
            {
                conn.Open();

                if (!TableExists(conn, "Users"))
                {
                    Run(conn,
                        "CREATE TABLE [Users] (" +
                        "[UserID] AUTOINCREMENT PRIMARY KEY, " +
                        "[FullName] TEXT(100), " +
                        "[Username] TEXT(50), " +
                        "[Email] TEXT(100), " +
                        "[PasswordHash] TEXT(100), " +
                        "[Salt] TEXT(50), " +
                        "[DateCreated] DATETIME)");
                }

                if (!TableExists(conn, "Products"))
                {
                    Run(conn,
                        "CREATE TABLE [Products] (" +
                        "[ProductID] AUTOINCREMENT PRIMARY KEY, " +
                        "[ProductName] TEXT(100), " +
                        "[Category] TEXT(50), " +
                        "[Description] LONGTEXT, " +
                        "[UnitPrice] CURRENCY, " +
                        "[Quantity] LONG, " +
                        "[ReorderLevel] LONG, " +
                        "[DateAdded] DATETIME)");
                }
            }
        }

        private static bool TableExists(OleDbConnection conn, string name)
        {
            DataTable t = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                new object[] { null, null, name, "TABLE" });
            return t != null && t.Rows.Count > 0;
        }

        private static void Run(OleDbConnection conn, string sql)
        {
            using (var cmd = new OleDbCommand(sql, conn))
                cmd.ExecuteNonQuery();
        }
    }
}
