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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        Context context = new Context();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    Name = nametextBox.Text,
                    Phone = phonetextBox.Text,
                    Email = emailtextBox.Text,
                    Address = addresstextBox.Text,

                };
                context.Customers.Add(customer);
                context.SaveChanges();
                nametextBox.Text = String.Empty;
                phonetextBox.Text = String.Empty;
                addresstextBox.Text = String.Empty;
                emailtextBox.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }
    }
}
