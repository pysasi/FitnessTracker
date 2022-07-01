using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public class Connection
    {
        private string connectionString;

        public Connection()
        {
            connectionString = @"Server=tcp:ysasi-development.database.windows.net,1433;Initial Catalog=FitnessTracker;Persist Security Info=False;User ID=pysasi;Password=0101SRY@pay;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }

        public string GetWorkoutType()
        {
            string type = "";
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "select workouttype from workouttype where workouttypeid = (Select WorkoutType from WorkoutDescription)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            type = reader.GetValue(0).ToString();
                        }

                    }
                }
            }
            return type;
        }

        public string GetDescription()
        {
            string description = "";
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "Select WorkoutDescription from WorkoutDescription";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open(); 
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            description = reader.GetValue(0).ToString();
                        }
                        
                    }
                }               
            }
            return description;
        }
    }
}
