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


namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }



        Context context = new Context();

        private void addProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {


            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@search";
            p1.SqlDbType = System.Data.SqlDbType.NVarChar;
            p1.Value = searchtextBox.Text;


            if (numradioButton.Checked == true)
            {
                IEnumerable<Product> productList = context.Products.SqlQuery("SELECT * FROM Products WHERE PartNumber=@search", p1);
                GridView.DataSource = productList.ToList();
            }
            else if (descradioButton.Checked == true)
            {
                IEnumerable<Product> productList = context.Products.SqlQuery("SELECT * FROM Products WHERE ProductName=@search", p1);
                GridView.DataSource = productList.ToList();

            }
            else
            {
                IEnumerable<Product> productList = context.Products.SqlQuery("SELECT * FROM Products WHERE PartNumber=@search", p1);
                GridView.DataSource = productList.ToList();
            }

            

        }

        private void searchtextBox_Click(object sender, EventArgs e)
        {
            searchtextBox.Clear();
        }

        private void searchtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSearch_Click(searchtextBox.Text, e);
        }

        public static List<Product> neworderlist = new List<Product>();


        


        private void GridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(GridView[7, e.RowIndex].Value) > 0)
                {
                    if ((Convert.ToInt32(GridView[6, e.RowIndex].Value) >= Convert.ToInt32(GridView[7, e.RowIndex].Value)))
                    {
                        if (!neworderlist.Contains((Product)GridView.CurrentRow.DataBoundItem))
                        {
                            neworderlist.Add((Product)GridView.CurrentRow.DataBoundItem);
                            int inCartProducts = neworderlist.Count();
                            inCartLabel.Text = inCartProducts.ToString();
                            inCartLabel.ForeColor = Color.Red;
                            label1.ForeColor = Color.Red;
                            label2.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Количество в заказе не может быть больше количества на складе");
                    }
                }
            }
            catch (Exception exc) { }
        }

        private void toOrder_Click(object sender, EventArgs e)
        {
            OrderForm newOrder = new OrderForm(neworderlist);
            newOrder.Show();
        }

        private void clearCartButton_Click(object sender, EventArgs e)
        {
            neworderlist.Clear();
            int inCartProducts = neworderlist.Count();
            inCartLabel.Text = inCartProducts.ToString();

            inCartLabel.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            int inCartProducts = neworderlist.Count();
            inCartLabel.Text = inCartProducts.ToString();
        }

        private void repButton_Click(object sender, EventArgs e)
        {
            ReportsForm newReportsForm = new ReportsForm();
            newReportsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPriceForm newLoadPriceForm = new LoadPriceForm();
            newLoadPriceForm.Show();
        }
    }
    
}
