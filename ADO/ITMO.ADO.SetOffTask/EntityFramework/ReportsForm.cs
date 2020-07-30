using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using CodeFirst;
using System.Data.SqlClient;
using System.Configuration;

namespace EntityFramework
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            label3.Text = "";
        }
        Context context = new Context();


        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
        string connectionString = GetConnectionStringByName("AutoShopConnectionString");

        private void custRepButton_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            repGridView.DataSource = context.Customers.ToList();
        }

        private void prodRepButton_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            repGridView.DataSource = context.Products.ToList();
        }

        

        private void salesRepButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT OrderId AS 'Номер заказа', DateOrder AS 'Дата', TimeOrder AS 'Время заказа', CustomerName AS 'Покупатель', OrderTotalPrice AS 'Сумма заказа' FROM OrdersView WHERE DateOrder BETWEEN CONVERT(date, '" + dateTimePicker2.Text + "', 0) AND CONVERT(date, '" + dateTimePicker3.Text + "', 0)";
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);

            DataSet OrdersViewDataSet = new DataSet("OrdersView");
            da.Fill(OrdersViewDataSet, "OrdersView");
            repGridView.DataSource = OrdersViewDataSet.Tables["OrdersView"];


            int quant = 0;
            double sum = 0;
            foreach (DataRow dr in OrdersViewDataSet.Tables["OrdersView"].Rows)
            {
                sum += (double)dr["Сумма заказа"];
                quant += 1;
            }

            label3.Text = "Итого " + quant + " заказов на сумму " + sum;

        }

        private void SoldProdsRepButton_Click(object sender, EventArgs e)
        {

            string query = "SELECT OrderId AS 'Номер заказа', DateOrder AS 'Дата', TimeOrder AS 'Время заказа', Name AS 'Покупатель', Vendor AS 'Поставщик', Brand AS 'Бренд', PartNumber AS 'Номер артикула', ProductName AS 'Наименование', Price AS 'Цена', QuantityInOrder AS 'Кол-во', TotalPrice AS 'Сумма' FROM SoldProductsView WHERE DateOrder BETWEEN CONVERT(date, '" + dateTimePicker2.Text + "', 0) AND CONVERT(date, '" + dateTimePicker3.Text + "', 0)";
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);

            DataSet SoldProductsViewDataSet = new DataSet("SoldProductsView");
            da.Fill(SoldProductsViewDataSet, "SoldProductsView");
            repGridView.DataSource = SoldProductsViewDataSet.Tables["SoldProductsView"];

            int quant = 0;
            double sum = 0;
            foreach (DataRow dr in SoldProductsViewDataSet.Tables["SoldProductsView"].Rows)
            {
                sum += (double)dr["Сумма"];
                quant += 1;
            }

            label3.Text = "Итого " + quant + " артикулов на сумму " + sum;
        }
    }
}
