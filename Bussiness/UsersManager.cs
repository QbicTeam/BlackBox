using BlackBox.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBox.Bussiness
{
    public class UsersManager
    {
        private SqlConnection _conn;

        private const string FLD_ID = "UserId";
        private const string FLD_USER_NAME = "username";
        private const string FLD_NOMBRE = "nombre";
        private const string FLD_PUESTO = "puesto";
        private const string FLD_STATUS = "status";
        private const string FLD_PASSWORD_SALT = "pwdSalt";
        private const string FLD_PASSWORD_HASH = "pwdHash";

        private const string SP_SAVE = "users_save";
        private const string SP_UPDATE = "users_update";
        private const string SP_GET_BY_ID = "users_getById";
        private const string SP_GET_BY_USERNAME = "users_getByUsername";
        private const string SP_GET_ALL_USERS = "users_getAllUsers";


        public UsersManager(string connectionString)
        {
            this._conn = new SqlConnection(connectionString);
        }

        public bool Save(User user)
        {
            bool result = false;

            byte[] passwordHash;
            byte[] passwordSalt;

            CreatePasswordHash(user.Password, out passwordHash, out passwordSalt);

            SqlCommand cmd = new SqlCommand(SP_SAVE, this._conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prm = new SqlParameter();
            prm.ParameterName = FLD_NOMBRE;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.VarChar;
            prm.Size = 100;
            prm.Value = user.Nombre;
            cmd.Parameters.Add(prm);

            prm = new SqlParameter();
            prm.ParameterName = FLD_USER_NAME;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.VarChar;
            prm.Size = 50;
            prm.Value = user.UserName;
            cmd.Parameters.Add(prm);

            prm = new SqlParameter();
            prm.ParameterName = FLD_PUESTO;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.VarChar;
            prm.Size = 15;
            prm.Value = user.Puesto;
            cmd.Parameters.Add(prm);

            prm = new SqlParameter();
            prm.ParameterName = FLD_STATUS;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.VarChar;
            prm.Size = 10;
            prm.Value = user.Status;
            cmd.Parameters.Add(prm);

            prm = new SqlParameter();
            prm.ParameterName = FLD_PASSWORD_SALT;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.VarBinary;
            // prm.Size = 250;
            prm.Value = passwordSalt;
            cmd.Parameters.Add(prm);

            prm = new SqlParameter();
            prm.ParameterName = FLD_PASSWORD_HASH;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.VarBinary;
            // prm.Size = 250;
            prm.Value = passwordHash;
            cmd.Parameters.Add(prm);

            this._conn.Open();

            int userId = Convert.ToInt32(cmd.ExecuteScalar());

            if (userId > 0)
            {
                result = true;
            }

            this._conn.Close();

            return result;
        }

        public bool Update(User user)
        {
            bool result = false;

            SqlCommand cmd = new SqlCommand(SP_UPDATE, this._conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prm = new SqlParameter();
            prm.ParameterName = FLD_ID;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.Int;
            prm.Value = user.Id;
            cmd.Parameters.Add(prm);

            prm = new SqlParameter();
            prm.ParameterName = FLD_NOMBRE;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.VarChar;
            prm.Size = 50;
            prm.Value = user.Nombre;
            cmd.Parameters.Add(prm);

            prm = new SqlParameter();
            prm.ParameterName = FLD_USER_NAME;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.VarChar;
            prm.Size = 50;
            prm.Value = user.UserName;
            cmd.Parameters.Add(prm);

            prm = new SqlParameter();
            prm.ParameterName = FLD_PUESTO;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.VarChar;
            prm.Size = 15;
            prm.Value = user.Puesto;
            cmd.Parameters.Add(prm);

            prm = new SqlParameter();
            prm.ParameterName = FLD_STATUS;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.VarChar;
            prm.Size = 10;
            prm.Value = user.Status;
            cmd.Parameters.Add(prm);

            prm = new SqlParameter();
            prm.ParameterName = FLD_PASSWORD_SALT;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.VarBinary;
            //prm.Size = 250;
            prm.Value = user.PasswordSalt;
            cmd.Parameters.Add(prm);

            prm = new SqlParameter();
            prm.ParameterName = FLD_PASSWORD_HASH;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.VarBinary;
            //prm.Size = 250;
            prm.Value = user.PasswordHash;
            cmd.Parameters.Add(prm);

            this._conn.Open();

            int recordsUpdated = cmd.ExecuteNonQuery();

            if (recordsUpdated > 0)
            {
                result = true;
            }

            this._conn.Close();

            return result;

        }

        public List<User> GetUsersList()
        {
            List<User> users = new List<User>();

            SqlCommand cmd = new SqlCommand(SP_GET_ALL_USERS, this._conn);
            cmd.CommandType = CommandType.StoredProcedure;

            this._conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    users.Add(new User
                    {
                        Id = Convert.ToInt32(reader[FLD_ID]),
                        Nombre = reader[FLD_NOMBRE].ToString()
                    });
                }
            }

            this._conn.Close();

            return users;
        }

        public User GetUserById(int userId)
        {
            User result = null;

            SqlCommand cmd = new SqlCommand(SP_GET_BY_ID, this._conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prm = new SqlParameter();
            prm.ParameterName = FLD_ID;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.Int;
            prm.Value = userId;
            cmd.Parameters.Add(prm);

            this._conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                result = new User
                    {
                        Id = Convert.ToInt32(reader[FLD_ID]),
                        Nombre = reader[FLD_NOMBRE].ToString(),
                        Puesto = reader[FLD_PUESTO].ToString(),
                        Status = reader[FLD_STATUS].ToString(),
                        UserName = reader[FLD_USER_NAME].ToString(),
                };
            }

            this._conn.Close();

            return result;
        }

        public User GetUserByUserName(string username)
        {
            User result = null;

            SqlCommand cmd = new SqlCommand(SP_GET_BY_USERNAME, this._conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prm = new SqlParameter();
            prm.ParameterName = FLD_USER_NAME;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.VarChar;
            prm.Size = 255;
            prm.Value = username;
            cmd.Parameters.Add(prm);

            this._conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                result = new User
                {
                    Id = Convert.ToInt32(reader[FLD_ID]),
                    Nombre = reader[FLD_NOMBRE].ToString(),
                    Puesto = reader[FLD_PUESTO].ToString(),
                    Status = reader[FLD_STATUS].ToString(),
                    PasswordSalt = (byte[])reader[FLD_PASSWORD_SALT],
                    PasswordHash = (byte[])reader[FLD_PASSWORD_HASH]
                };
            }

            this._conn.Close();

            return result;
        }

        public User Login(string userName, string userPwd)
        {

            User user = GetUserByUserName(userName);

            if (user == null)
            {
                return null;
            }

            if (!VerifyPasswordHash(userPwd, user.PasswordHash, user.PasswordSalt))
            {
                return null;
            }

            if (user.Status != "Activo")
            {
                return null;
            }

            return user;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

        }

        private bool VerifyPasswordHash(string password, byte[] PasswordHash, byte[] PasswordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(PasswordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                for (int idx = 0; idx < computedHash.Length; idx++)
                {
                    if (computedHash[idx] != PasswordHash[idx]) return false;
                }
            }

            return true;
        }
    }
}
