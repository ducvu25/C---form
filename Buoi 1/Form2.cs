﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string str;
        private void Form2_Load(object sender, EventArgs e)
        {
            lblChao.Text = "Xin chào " + str; 
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
