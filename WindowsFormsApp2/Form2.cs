using System;
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
    public partial class Form2 : Form
    {
        bool Stop = false;
        bool Stop2 = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(Stop == true && Stop2 == true)
            {
                string value = textBox5.Text;        //value 에 text box5의 값을 넣어준다.
                int value2 = Convert.ToInt32(value); //value2에 value 를 형변환 한 값을 넣어준다.
                value2++;                            //value2에 값을 1추가한다.
                if (value2 == 51) value2--;          //값이 51 이상 될때 --해서 50이상 못올라가도록 예외처리
                textBox5.Text = value2.ToString();   //다시 textBox5.Text 에 value2 값을 스트링으로 형변환해 넣어준다.
                textBox1.Text = "위로 이동";
            }
            else if (Stop == true && Stop2 == false) textBox7.Text = "수동 모드 요망 ";
            else textBox7.Text = "정지 요망 ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Stop == true && Stop2 == true)
            {
                string value = textBox5.Text;        //value 에 text box5의 값을 넣어준다.
                int value2 = Convert.ToInt32(value); //value2에 value 를 형변환 한 값을 넣어준다.
                value2--;                            //value2에 값을 1을 뺀다.
                if (value2 == -1) value2++;
                textBox5.Text = value2.ToString();   //다시 textBox5.Text 에 value2 값을 스트링으로 형변환해 넣어준다.
                textBox1.Text = "아래로 이동";

            }
            else if (Stop == true && Stop2 == false) textBox7.Text = "수동 모드 요망 ";
            else textBox7.Text = "정지 요망 ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Stop == true && Stop2 == true)
            {
                int value2 = Convert.ToInt32(textBox6.Text); //value2 에 textBox6.Text형변환 한값을 담는다.
                value2++;
                if (value2 == 51) value2--;
                textBox6.Text = value2.ToString();
                textBox1.Text = "좌로 이동";
            }
            else if (Stop == true && Stop2 == false) textBox7.Text = "수동 모드 요망 ";
            else textBox7.Text = "정지 요망 ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Stop == true && Stop2 == true)
            {
                int value2 = Convert.ToInt32(textBox6.Text);
                value2--;
                if (value2 == -1) value2++;
                textBox6.Text = value2.ToString();
                textBox1.Text = "우로 이동";
            }
            else if (Stop == true && Stop2 == false) textBox7.Text = "수동 모드 요망 ";
            else textBox7.Text = "정지 요망 ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double value2 = Convert.ToDouble(textBox2.Text); //value2 에 textBox6.Text형변환 한값을 담는다.
            value2 = value2 + 0.1;
            if (value2 == 30) value2 = value2 - 0.1;
            textBox2.Text = value2.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double value2 = Convert.ToDouble(textBox2.Text); //value2 에 textBox6.Text형변환 한값을 담는다.
            value2 = value2 - 0.1;
            if (value2 == 0) value2 = value2 + 0.1;
            textBox2.Text = value2.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double value2 = Convert.ToDouble(textBox3.Text); //value2 에 textBox6.Text형변환 한값을 담는다.
            value2 = value2 + 0.1;
            if (value2 == 8) value2 = value2 - 0.1;
            textBox3.Text = value2.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double value2 = Convert.ToDouble(textBox3.Text); //value2 에 textBox6.Text형변환 한값을 담는다.
            value2 = value2 - 0.1;
            if (value2 == 0) value2 = value2 + 0.1;
            textBox3.Text = value2.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox4.Text = button10.Text;
            textBox9.Text = textBox5.Text;
            textBox10.Text = textBox6.Text;
            textBox1.Text = "자동 동작중";
            textBox7.Text = "자동 조작";
            Stop = false;
            Stop2 = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(Stop == true) textBox4.Text = button11.Text;
            if (Stop == true) textBox7.Text = "수동 조작";
            Stop2 = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "정지";
            textBox7.Text = "정지";
            Stop = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
