using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentakuApp1
{
    public partial class Form1 : Form
    {
        private String key = "None";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Dentaku App";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calc("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calc("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calc("3");
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            key = "C";
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            key = "Plus";
        }


        private void Calc(String key_value)
        {
            if (key == "Plus"){
                label1.Text = (int.Parse(label1.Text) + int.Parse(key_value)).ToString();
                key = key_value;
            }else{
                label1.Text = key_value;
                key = key_value;
            }

        }

    }

}

