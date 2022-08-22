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
    public partial class Formcust : Form
    {
        public Formcust()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customcard1_Load(object sender, EventArgs e)
        {
            foreach (var item in Add.add)
            {
                Customcard customcard = new Customcard();
                customcard.Title = item.objname;
                customcard.Description = item.objname;
                customcard.Price = item.price;


            }
        }
}
