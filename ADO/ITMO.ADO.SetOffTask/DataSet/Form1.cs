using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = schoolDataSet1.Course1;
            sqlDataAdapter1.Fill(schoolDataSet1.Course1);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = schoolDataSet1.Person1;
            sqlDataAdapter2.Fill(schoolDataSet1.Person1);
        }
    }
}
