﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }
         private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for(int i=0; i<)
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] a = new int[15];
            int i=0;
            a[i]=Convert.ToInt32(sender);
            i++;
            Sorter.Input(a);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {

        }
    }
}
