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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if(activescreen != null)
            {
                activescreen.Close();
            }
            Form1 screen = new Form1 (" ");
            screen.MdiParent = this;
            screen.Show();
        }

        private void displayStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
            DisplayAll screen = new DisplayAll();
            screen.MdiParent = this;
            screen.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
            Search screen = new Search();
            screen.MdiParent = this;
            screen.Show();

        }
    }
}
