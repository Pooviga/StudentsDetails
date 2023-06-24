using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using StudentDetails.Model;
using System.Data;
using System.Data.Common;

namespace StudentDetails.DataAccess
{
    public class clsSql
    {
        private string ConnString= "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDetails;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public clsSql() { }

        public int InsertDetails(CreateAttributes d)
        {
            SqlConnection conn = new SqlConnection(ConnString);

            conn.Open();
            string query = $"INSERT INTO StudentDetails (Name,Number,Mail,City,Amount) VALUES('{d.Name}','{d.Number}','{d.Mail}','{d.City}','{d.Amount}')";
            //string query = $"UPDATE StudentDetails SET Name='Abarna',City='Salem' WHERE NAME='Pooviga'";

            SqlCommand objSqlCommand = new SqlCommand(query, conn);
            objSqlCommand.CommandText = query;
            objSqlCommand.Connection = conn;
            objSqlCommand.CommandType=System.Data.CommandType.Text;

            int resultsAffected = objSqlCommand.ExecuteNonQuery();
            if(conn.State==System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            return resultsAffected;
        }

        public DataTable FetchDetails()
        {
            SqlConnection conn = new SqlConnection(ConnString);

            conn.Open();
            string query = $"Select [Id],[Name],Number,Mail,City,Amount from StudentDetails";
            SqlCommand objSqlCommand = new SqlCommand(query, conn);
            objSqlCommand.CommandType = System.Data.CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(objSqlCommand);

            DataSet dsResults = new DataSet("StudentDetails");
            adapter.Fill(dsResults);

            return  dsResults.Tables[0];

            //string query = $"UPDATE StudentDetails SET Name='Abarna',City='Salem' WHERE NAME='Pooviga'";        
        }
        public int UpdateDetails(CreateAttributes d)
        {
            SqlConnection conn = new SqlConnection(ConnString);

            conn.Open();
            //string query = $"INSERT INTO StudentDetails (Name,Number,Mail,City,Amount) VALUES('{d.Name}','{d.Number}','{d.Mail}','{d.City}','{d.Amount}')";
            string query = $"UPDATE StudentDetails SET Name='{d.Name}',Number='{d.Number}',Mail='{d.Mail}',City='{d.City}',Amount={d.Amount} WHERE Id={d.Id}";

            SqlCommand objSqlCommand = new SqlCommand(query, conn);
            objSqlCommand.CommandText = query;
            objSqlCommand.Connection = conn;
            objSqlCommand.CommandType = System.Data.CommandType.Text;

            int resultsAffected = objSqlCommand.ExecuteNonQuery();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            return resultsAffected;
        }

        public int DeleteDetails(int d)
        {
            SqlConnection conn = new SqlConnection(ConnString);

            conn.Open();
            //string query = $"INSERT INTO StudentDetails (Name,Number,Mail,City,Amount) VALUES('{d.Name}','{d.Number}','{d.Mail}','{d.City}','{d.Amount}')";
            string query = $"Delete from StudentDetails WHERE Id={d}";

            SqlCommand objSqlCommand = new SqlCommand(query, conn);
            objSqlCommand.CommandText = query;
            objSqlCommand.Connection = conn;
            objSqlCommand.CommandType = System.Data.CommandType.Text;

            int resultsAffected = objSqlCommand.ExecuteNonQuery();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            return resultsAffected;
        }

    }
}