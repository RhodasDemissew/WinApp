using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp.loginf;

namespace WinApp
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnsrch_Click(object sender, EventArgs e)
        {
            var product = Add.findOne(textBox1.Text);
            if (product == null)
            {
                MessageBox.Show("Product not found");
            }
            else
                lblName.Text = product.objname;
        }
    }
}
