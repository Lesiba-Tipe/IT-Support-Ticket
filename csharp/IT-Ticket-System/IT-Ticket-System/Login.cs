using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IT_Ticket_System
{
    public partial class Login : UserControl
    {
        bool isLoggedIn;
        public Login()
        {
            InitializeComponent();
        }

        int type;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //var model = new Model();
            var select = $"SELECT Email,Password, Type FROM [User] WHERE Email = '{ txtEmail.Text}' AND Password = '{txtPassword.Text}'"; //... where id = 1

            //model.Select(select);
            type = new Random().Next(1, 4);
            switch (type)
            {
                case 1:
                    Host.panel.Controls.Clear();
                    Host.panel.Controls.Add(new Admin());
                    break;
                case 2:
                    Host.panel.Controls.Clear();
                    Host.panel.Controls.Add(new Technician());
                    break;
                case 3:
                    Host.panel.Controls.Clear();
                    Host.panel.Controls.Add(new Client());
                    break;
                
            }
        }

        private void Select(string select)
        {
            var results = new List<string>();
            try
            {
                using (var connection = new SqlConnection(Model.ConnectionString))
                {
                    try
                    {
                        var command = new SqlCommand(select, connection);
                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            //type = (int)reader["Type"];
                            //isLoggedIn = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to select from database: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to database: " + ex.Message);
            }
        }
    }
}
