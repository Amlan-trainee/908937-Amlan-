using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;

namespace PlayersManagerLib
{
    public interface IPlayerMapper
    {
        bool IsPlayerNameExistsInDb(string name);
        void AddNewPlayerIntoDb(string name);
    }
    public class PlayerMapper:IPlayerMapper
    {
        private readonly string _connectionString = "data source=(local);initial catalog=GameDB;integrated security=true;";

        public void AddNewPlayerIntoDb(string name)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "Insert into Player ([Name]) values (@name)";
                    command.Parameters.AddWithValue("@name", name);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool IsPlayerNameExistsInDb(string name)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "select count(*) from Player where 'Name'=@name";
                    command.Parameters.AddWithValue("@name", name);
                    var existingPlayerCount = (int)command.ExecuteScalar();
                    return existingPlayerCount > 0;
                }
            }
        }
    }
}
