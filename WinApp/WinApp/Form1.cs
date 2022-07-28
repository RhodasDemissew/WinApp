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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.number = Convert.ToInt32(txt_num.Text);
            add.date = Convert.ToDateTime(txt_date.Text);
            add.invnumber = Convert.ToInt32(txt_invnum.Text);
            add.objname = txt_objname.Text;
            add.count = Convert.ToInt32(txt_count.Text);
            add.price = Convert.ToDouble(txt_price.Text);
            MessageBox.Show(add.save());
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
