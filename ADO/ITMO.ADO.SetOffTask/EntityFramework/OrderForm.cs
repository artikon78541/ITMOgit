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
using System.Data.Sql;
using System.Diagnostics.SymbolStore;

namespace EntityFramework
{
    public partial class OrderForm : Form
    {
        Context context = new Context();

        public OrderForm()
        {
            InitializeComponent();

        }
        List<Product> neworderlist = new List<Product>();

        public OrderForm(List<Product> P)
        {
            InitializeComponent();
            neworderlist = P;
            orderGridView.DataSource = neworderlist.ToList();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            var namelist = from a in context.Customers select a.Name;
                 

            AutoCompleteStringCollection sourcename = new AutoCompleteStringCollection();
            sourcename.AddRange(namelist.ToArray());

            clientTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            clientTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            clientTextBox.AutoCompleteCustomSource = sourcename;
        }

        private void makeAnOrder_Click(object sender, EventArgs e)
        {
            double sum = 0;
            foreach (Product p in neworderlist)
            {
                sum = (double)(sum + p.Price * p.QuantityInOrder);
            }

            var ordercustomer = context.Customers.Where(c => c.Name == clientTextBox.Text).SingleOrDefault();

            try
            {
                Order order = new Order
                {
                    PurchaseDate = DateTime.Now,
                    Customer = ordercustomer,
                    OrderTotalPrice = sum,
                };
                context.Orders.Add(order);

                foreach (Product p in neworderlist)
                {
                    ProductsInOrder newlines = new ProductsInOrder
                    {
                        Vendor = p.Vendor,
                        Brand = p.Brand,
                        PartNumber = p.PartNumber,
                        ProductName = p.ProductName,
                        Price = p.Price,
                        QuantityInOrder = (int)p.QuantityInOrder,
                        TotalPrice = (double)(p.QuantityInOrder * p.Price)
                    };
                    context.ProductsInOrders.Add(newlines);
                }
                context.SaveChanges();
                neworderlist.Clear();
                Close();
                Form1.neworderlist.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }

        }
    }
}
