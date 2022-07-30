using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IT_Ticket_System
{
    public class Model
    {
        public static string ConnectionString = "Data Source=tipe;Initial Catalog=IT-Support-System;Integrated Security=True";
        private SqlConnection connection = new SqlConnection(ConnectionString);

        public void Insert(string insert)
        {
            try
            {
                connection.Open();
                try
                {
                    MessageBox.Show("Connection Succeded");

                    var command = new SqlCommand(insert, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to insert to database: " + ex.Message);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to database: " + ex.Message);
            }
        }

        
    }
}
