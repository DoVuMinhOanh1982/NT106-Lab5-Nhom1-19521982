﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Nhom1_19521982
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYc3_Click(object sender, EventArgs e)
        {
            Bai1_Lab5 bai1_Lab5 = new Bai1_Lab5();
            bai1_Lab5.Show();
        }

        private void btnYc4_Click(object sender, EventArgs e)
        {
            Bai2_Lab5 bai2_Lab5 = new Bai2_Lab5();
            bai2_Lab5.Show();
        }

        private void btnYc5_Click(object sender, EventArgs e)
        {
            Bai3_Lab5 bai3_Lab5 = new Bai3_Lab5();
            bai3_Lab5.Show();
        }
    }
}
