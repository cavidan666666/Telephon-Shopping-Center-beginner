﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox7.Items.Add(textBox3.Text);
            listBox6.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            listBox3.Items.Add(label13.Text + " " + label14.Text + " " + label15.Text + " " + label16.Text + " " + label17.Text + " " + label18.Text);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            label13.Text = checkBox1.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label14.Text = checkBox2.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label15.Text = checkBox3.Text;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label16.Text = checkBox4.Text;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label17.Text = checkBox5.Text;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            label18.Text = checkBox6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;

            listBox1.Text ="";
        }
    }
}
