﻿using System;
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
    public partial class DisplayAll : Form
    {
        public DisplayAll()
        {
            InitializeComponent();
            Add.get();
            dgv1.DataSource = null;
            dgv1.DataSource = Add.get();
        }

        private void DisplayAll_Load(object sender, EventArgs e)
        {

        }
    }
}
