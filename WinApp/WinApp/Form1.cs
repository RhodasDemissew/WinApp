using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp.loginf;
namespace WinApp
{
    public partial class Form1 : Form
    {
        private string username;

        public Form1( String user)
        {
            InitializeComponent();
            label4.Text = user;
        }

      

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            bool flag = false;

            Regex regex = new Regex(@"^[a-z]{2}$");
            add.number = Convert.ToInt32(txt_num.Text);
            add.date = Convert.ToDateTime(txt_date.Text);
            add.invnumber = Convert.ToInt32(txt_invnum.Text);
            add.objname = txt_objname.Text;
            add.count = Convert.ToInt32(txt_count.Text);
            add.price = Convert.ToDouble(txt_price.Text);
            add.isAvailable = checkBox1.Checked;
            if (txt_num.Text.Length < 5)

            {
                errorprovider.SetError(txt_num, "Digits must be 5");
            }
            //Checks if the Object name is given  
            else if (string.IsNullOrEmpty(txt_objname.Text))
            {
                errorprovider.SetError(txt_objname, "Object name is required");
            }
            //Checks if count is entered
            else if (txt_count.Text.Length < 1)
            {
                errorprovider.SetError(txt_count, "Count is required");
            }
            else
            {
                errorprovider.Clear();
                flag = true;
            }
            
            if (flag)
            {
                MessageBox.Show(add.save() + " has been Successfully Added!!!");
                //Item.getAll();
               // dgv.DataSource = null;
                //dgv.DataSource = Add.get();
            }

        }
           

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (rdbtnsimple.Checked)
                MessageBox.Show("Simple");
            else if (rdbtnVariable.Checked)
                MessageBox.Show("Variable");
            else
                Console.WriteLine(" ");

            String message = " ";
            foreach(var choice in chkList.CheckedItems)
            {
                message += choice.ToString()+" ";
            }
            MessageBox.Show(message);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
