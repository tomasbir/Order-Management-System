﻿using System;
using Business;
using DataAccess;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace Order_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            AllOrdersOfClient clients = new AllOrdersOfClient();
            string result = "";

            result = clients.Generate();

            displayBlock.Text = result;
        }
    }
}
