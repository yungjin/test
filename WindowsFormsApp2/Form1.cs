﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    private void button1_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Form2 f2 = new Form2(); //객체를 만들어 
            f2.Show();              //부모 클래스 안의 메소드를 이용해 화면을 띄운다.
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
