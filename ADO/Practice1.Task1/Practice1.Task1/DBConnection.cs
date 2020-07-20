using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1.Task1
{
    public partial class DBConnection : Form
    {
        public DBConnection()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection();
        string connectionString = @"Data Source=((LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";

        private void connectionMS_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных " + connection.Database + " выполнено успешно " + "\nСервер: " + connection.DataSource);
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
}
            catch
            {
               MessageBox.Show("Ошибка соединения с базой данных");
            }
        }

        private void DisconnectionMS_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }
    }
}
