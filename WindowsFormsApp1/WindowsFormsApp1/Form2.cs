using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form 
    {
        public Form2() 
        {
            InitializeComponent();
            comboBox1.Text = "1단계";
        }


        //Y축
        private void button1_Click(object sender, EventArgs e)
        {
            double value2 = Convert.ToDouble(textBox2.Text);
            if (value2 == 20) value2 = 20;
            else value2 = value2 + 0.1;
            textBox2.Text = value2.ToString();
        }
        //X축
        private void button3_Click(object sender, EventArgs e)
        {
            double value2 = Convert.ToDouble(textBox5.Text);
            if (value2 == 20) value2 = 20;
            else value2 = value2 + 0.1;
            textBox5.Text = value2.ToString();
        }
        //X축
        private void button2_Click(object sender, EventArgs e)
        {
            Double value2 = Convert.ToDouble(textBox5.Text);
            if (value2 == 0) value2 = 0;
            else value2 = value2 - 0.1;
            textBox5.Text = value2.ToString();
        }
        //Y축
        private void button4_Click(object sender, EventArgs e)
        {
            Double value2 = Convert.ToDouble(textBox2.Text);
            if (value2 == 0) value2 = 0;
            else value2 = value2 - 0.1;
            textBox2.Text = value2.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double value2 = Convert.ToDouble(textBox1.Text);
            if (value2 == 4) value2 = 4;
            else value2 = value2 + 0.1;
            textBox1.Text = value2.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {

            double value2 = Convert.ToDouble(textBox1.Text);
            if (value2 == 0) value2 = 0;
            else value2 = value2 - 0.1;
            textBox1.Text = value2.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label5.Text = Passvalue;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Enabled = !panel2.Enabled;
            panel4.Enabled = !panel4.Enabled;
            textBox2.Text = "12.2";
            textBox5.Text = "10.0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Enabled = false;
            panel2.Enabled = false;
            panel4.Enabled = false;
            string Covalue = comboBox1.SelectedItem.ToString();
            if (radioButton1.Checked == true) textBox6.Text = "자동모드로 동작합니다." + "속도는" + Covalue;
            else if(radioButton1.Checked == false && radioButton2.Checked == false)
            {
                textBox6.Text = "모드를 선택해주세요";
                panel3.Enabled = true;
                panel2.Enabled = true;
                panel4.Enabled = true;
            }
            else if(radioButton2.Checked == true)
            {
                textBox6.Text = "수동모드 선택! 중량은 " + textBox1.Text + "t 위치좌표 X축 : " + textBox5.Text + " Y축 : " + textBox2.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "STOP 기계를 멈춥니다.";
            panel3.Enabled = true;
            panel2.Enabled = true;
            panel4.Enabled = true;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            FORM1 f1 = new FORM1();
            f1.Show();
        }
        private string Form2_value;
        
        public string Passvalue
        {
            get { return this.Form2_value; }
            set { this.Form2_value = value; }
        }
    }
}
