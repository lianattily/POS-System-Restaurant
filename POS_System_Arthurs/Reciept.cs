﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_Arthurs
{
    public partial class Reciept : Form
    {
        public Reciept()
        {
            InitializeComponent();
        }

       /* public Reciept(List<Order> order)
        {

        }*/

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reciept_Load(object sender, EventArgs e)
        {

        }
    }
}
