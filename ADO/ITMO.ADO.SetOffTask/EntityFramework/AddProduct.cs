using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirst;
using System.Data.Entity;

namespace EntityFramework
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        Context context = new Context();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    Vendor = vendortextBox.Text,
                    Brand = brandtextBox.Text,
                    PartNumber = numbertextBox.Text,
                    ProductName = descriptiontextBox.Text,
                    Price = Double.Parse(pricetextBox.Text),
                    QuantityInStock = Int32.Parse(quantitytextBox.Text)
                };
                context.Products.Add(product);
                context.SaveChanges();
                vendortextBox.Text = String.Empty;
                brandtextBox.Text = String.Empty;
                numbertextBox.Text = String.Empty;
                descriptiontextBox.Text = String.Empty;
                pricetextBox.Text = String.Empty;
                quantitytextBox.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }
    }
    
}
