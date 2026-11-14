using System;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace InventoryManagementSystem
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
    }

    /// <summary>Register and sign-in. Passwords are stored as salted hashes, never as plain text.</summary>
    public class UserRepository
    {
        public bool Register(string fullName, string username, string email, string password, out string error)
        {
            error = "";

            using (OleDbConnection conn = Database.Open())
            {
                if (Exists(conn, "Username", username))
                {
                    error = "That username is already taken.";
                    return false;
                }
                if (Exists(conn, "Email", email))
                {
                    error = "That email is already registered.";
                    return false;
                }

                string salt = NewSalt();
                string hash = Hash(password, salt);

                const string sql =
                    "INSERT INTO [Users] ([FullName], [Username], [Email], [PasswordHash], [Salt], [DateCreated]) " +
                    "VALUES (?, ?, ?, ?, ?, ?)";
                using (var cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.Add("@name", OleDbType.VarWChar).Value = fullName;
                    cmd.Parameters.Add("@user", OleDbType.VarWChar).Value = username;
                    cmd.Parameters.Add("@mail", OleDbType.VarWChar).Value = email;
                    cmd.Parameters.Add("@hash", OleDbType.VarWChar).Value = hash;
                    cmd.Parameters.Add("@salt", OleDbType.VarWChar).Value = salt;
                    cmd.Parameters.Add("@date", OleDbType.Date).Value = DateTime.Now;
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }

        // Returns the user when the username/password match, otherwise null
        public User Authenticate(string username, string password)
        {
            const string sql =
                "SELECT [UserID], [FullName], [Username], [PasswordHash], [Salt] FROM [Users] WHERE [Username] = ?";

            using (OleDbConnection conn = Database.Open())
            using (var cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.Add("@user", OleDbType.VarWChar).Value = username;
                using (OleDbDataReader r = cmd.ExecuteReader())
                {
                    if (!r.Read()) return null;

                    string salt = Convert.ToString(r["Salt"]);
                    string stored = Convert.ToString(r["PasswordHash"]);
                    if (Hash(password, salt) != stored) return null;

                    return new User
                    {
                        Id = Convert.ToInt32(r["UserID"]),
                        FullName = Convert.ToString(r["FullName"]),
                        Username = Convert.ToString(r["Username"])
                    };
                }
            }
        }

        private static bool Exists(OleDbConnection conn, string column, string value)
        {
            string sql = "SELECT COUNT(*) FROM [Users] WHERE [" + column + "] = ?";
            using (var cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.Add("@v", OleDbType.VarWChar).Value = value;
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private static string NewSalt()
        {
            byte[] bytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
                rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }

        private static string Hash(string password, string salt)
        {
            using (var kdf = new Rfc2898DeriveBytes(password, Convert.FromBase64String(salt), 10000))
                return Convert.ToBase64String(kdf.GetBytes(32));
        }
    }
}
