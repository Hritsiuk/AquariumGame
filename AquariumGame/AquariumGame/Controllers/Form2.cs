﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquariumGame.Controllers
{
    public partial class Form2 : Form
    {
        TestC test;
        public Form2()
        {
            InitializeComponent();
            test = new TestC();
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string[] word = sender.ToString().Split();


            if (word[2]==label1.Text)
            {
                test.GunSetorGetFish(0);
            }
            if (word[2] == label2.Text)
            {
                test.GunSetorGetFish(1);
            }
            if (word[2] == label3.Text)
            {
                test.GunSetorGetFish(2);
            }
            if (word[2] == label4.Text)
            {
                test.GunSetorGetFish(3);
            }
            if (word[2] == label5.Text)
            {
                test.GunSetorGetFish(4);
            }
            if (word[2] == label6.Text)
            {
                test.GunSetorGetFish(5);
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            test.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test.Refresh();
        }
    }
}
