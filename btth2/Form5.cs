﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btth2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_fb_Click(object sender, EventArgs e)
        {
            Form6 page = new Form6();
            page.Show();
        }

        private void btn_his_Click(object sender, EventArgs e)
        {
            Form7 page = new Form7();
            page.Show();
        }
    }
}
