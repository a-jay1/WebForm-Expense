using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;


namespace Expense
{
    public class Db
    {
        private static string name = "ajay";

        private static string connectionString = WebConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public static void setName(string userName)
        {
            if (userName != null)
            {
                //name = userName;
            }
        }

        public static string getName()
        {
            return name;
        }

        public SqlConnection getConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static string getExpense()
        {
            Db db = new Db();
            using (var connection = db.getConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT SUM(cost_) FROM expense WHERE name_ = @name ";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    return Convert.ToString(command.ExecuteScalar());

                }
                catch
                {
                    return "0";
                }
            }
        }

        public void insertModel(InputDetails model)
        {
            Db db = new Db();
            using (var connection = db.getConnection())
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("insert_procedure", connection))
                    {
                        //@name,@cost,@session,@date,@time,@info
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@name", getName());
                        command.Parameters.AddWithValue("@cost", model.amount);
                        command.Parameters.AddWithValue("@session", model.session);
                        command.Parameters.AddWithValue("@date", model.date);
                        command.Parameters.AddWithValue("@time", DateTime.Now);
                        command.Parameters.AddWithValue("@info", model.msg);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                catch
                {
                    
                }
            }
        }


        public static string getExpenseByYear(int year)
        {
            Db db = new Db();
            using (var connection = db.getConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT SUM(cost_) FROM expense WHERE name_ = @name and YEAR(date_) = @yr";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@yr", year);
                    return Convert.ToString(command.ExecuteScalar());
                }
                catch
                {
                    return "0";
                }
            }
        }

        public static string getExpenseByMonth(int month)
        {
            Db db = new Db();
            using (var connection = db.getConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT SUM(cost_) FROM expense WHERE name_ = @name and MONTH(date_) = @month";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@month", month);
                    int a = (int)command.ExecuteScalar();
                    return Convert.ToString(a);

                }
                catch
                {
                    return "0";
                }
            }
        }

        public static string getExpenseByDate(DateTime date)
        {
            Db db = new Db();
            using (var connection = db.getConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT SUM(cost_) FROM expense WHERE name_ = @name and date_ = @date";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@date", date);
                    return Convert.ToString(command.ExecuteScalar());

                }
                catch
                {
                    return "0";
                }
            }
        }


    }

    public class InputDetails
    {
        public int amount { get; set; }
        public DateTime date { get; set; }
        public string session { get; set; }
        public string msg { get; set; }
    }
}