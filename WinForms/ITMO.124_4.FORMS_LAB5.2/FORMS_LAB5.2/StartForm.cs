using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMS_LAB5._2
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void OpenForm_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();
            newForm.MdiParent = this;
            newForm.Show();

        }

        private void CloseForm_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
