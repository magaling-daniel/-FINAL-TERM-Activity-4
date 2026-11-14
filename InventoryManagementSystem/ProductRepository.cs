using System;
using System.Data;
using System.Data.OleDb;

namespace InventoryManagementSystem
{
    /// <summary>One row of the Products table.</summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int ReorderLevel { get; set; }
    }

    /// <summary>Numbers shown on the four cards at the top of the dashboard.</summary>
    public class ProductStats
    {
        public int Total { get; set; }
        public int InStock { get; set; }
        public int LowStock { get; set; }
        public int OutOfStock { get; set; }
    }

    /// <summary>All database work for the Products table (OleDb / Access).</summary>
    public class ProductRepository
    {
        private static OleDbConnection Open()
        {
            return Database.Open();
        }

        // ------------------------------------------------------------ read
        public DataTable GetAll(string search)
        {
            string sql =
                "SELECT [ProductID], [ProductName], [Category], [Description], [UnitPrice], " +
                "[Quantity], [ReorderLevel], [DateAdded], " +
                "IIF([Quantity] <= 0, 'Out of Stock', IIF([Quantity] <= [ReorderLevel], 'Low Stock', 'In Stock')) AS [Status] " +
                "FROM [Products]";

            bool hasSearch = !string.IsNullOrWhiteSpace(search);
            if (hasSearch)
                sql += " WHERE [ProductName] LIKE ? OR [Category] LIKE ? OR [Description] LIKE ?";
            sql += " ORDER BY [ProductID] DESC";

            using (OleDbConnection conn = Open())
            using (var cmd = new OleDbCommand(sql, conn))
            {
                if (hasSearch)
                {
                    string like = "%" + search.Trim() + "%";
                    AddText(cmd, like);
                    AddText(cmd, like);
                    AddText(cmd, like);
                }

                var table = new DataTable();
                new OleDbDataAdapter(cmd).Fill(table);
                return table;
            }
        }

        public ProductStats GetStats()
        {
            const string sql =
                "SELECT COUNT(*) AS Total, " +
                "SUM(IIF([Quantity] <= 0, 1, 0)) AS OutStock, " +
                "SUM(IIF([Quantity] > 0 AND [Quantity] <= [ReorderLevel], 1, 0)) AS LowStock, " +
                "SUM(IIF([Quantity] > 0 AND [Quantity] > [ReorderLevel], 1, 0)) AS InStock " +
                "FROM [Products]";

            using (OleDbConnection conn = Open())
            using (var cmd = new OleDbCommand(sql, conn))
            using (OleDbDataReader r = cmd.ExecuteReader())
            {
                var s = new ProductStats();
                if (r.Read())
                {
                    s.Total = ToInt(r["Total"]);
                    s.OutOfStock = ToInt(r["OutStock"]);
                    s.LowStock = ToInt(r["LowStock"]);
                    s.InStock = ToInt(r["InStock"]);
                }
                return s;
            }
        }

        // True when another product already uses this name (excludeId = the product being edited, 0 for new).
        public bool NameExists(string name, int excludeId)
        {
            const string sql = "SELECT COUNT(*) FROM [Products] WHERE [ProductName] = ? AND [ProductID] <> ?";
            using (OleDbConnection conn = Open())
            using (var cmd = new OleDbCommand(sql, conn))
            {
                AddText(cmd, name);
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = excludeId;
                return ToInt(cmd.ExecuteScalar()) > 0;
            }
        }

        // ------------------------------------------------------------ write
        public void Add(Product p)
        {
            const string sql =
                "INSERT INTO [Products] ([ProductName], [Category], [Description], [UnitPrice], " +
                "[Quantity], [ReorderLevel], [DateAdded]) VALUES (?, ?, ?, ?, ?, ?, ?)";

            using (OleDbConnection conn = Open())
            using (var cmd = new OleDbCommand(sql, conn))
            {
                AddValues(cmd, p);
                cmd.Parameters.Add("@date", OleDbType.Date).Value = DateTime.Now;
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Product p)
        {
            const string sql =
                "UPDATE [Products] SET [ProductName] = ?, [Category] = ?, [Description] = ?, " +
                "[UnitPrice] = ?, [Quantity] = ?, [ReorderLevel] = ? WHERE [ProductID] = ?";

            using (OleDbConnection conn = Open())
            using (var cmd = new OleDbCommand(sql, conn))
            {
                AddValues(cmd, p);
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = p.Id;
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            const string sql = "DELETE FROM [Products] WHERE [ProductID] = ?";
            using (OleDbConnection conn = Open())
            using (var cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = id;
                cmd.ExecuteNonQuery();
            }
        }

        // ------------------------------------------------------------ helpers
        // OleDb parameters are positional, so the order here must match the SQL above.
        private static void AddValues(OleDbCommand cmd, Product p)
        {
            AddText(cmd, p.Name);
            AddText(cmd, p.Category);
            cmd.Parameters.Add("@desc", OleDbType.LongVarWChar).Value = p.Description ?? "";
            cmd.Parameters.Add("@price", OleDbType.Currency).Value = p.UnitPrice;
            cmd.Parameters.Add("@qty", OleDbType.Integer).Value = p.Quantity;
            cmd.Parameters.Add("@reorder", OleDbType.Integer).Value = p.ReorderLevel;
        }

        private static void AddText(OleDbCommand cmd, string value)
        {
            cmd.Parameters.Add("@t", OleDbType.VarWChar).Value = value ?? "";
        }

        private static int ToInt(object o)
        {
            return (o == null || o == DBNull.Value) ? 0 : Convert.ToInt32(o);
        }
    }
}
