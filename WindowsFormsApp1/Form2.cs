using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schubert
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnWeightPlus_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(lblWeightChange.Text);
            if (value < 3.0)
                value = value + 0.1;
            lblWeightChange.Text = value.ToString();
        }

        private void btnWeightMinus_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(lblWeightChange.Text);
            if (value > 0.1)
                value = value - 0.1;
            lblWeightChange.Text = value.ToString();
        }

        private void btnSpeedPlus_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(lblSpeedChange.Text);
            if (value < 2.0)
                value = value + 0.1;
            lblSpeedChange.Text = value.ToString();
        }

        private void btnSpeedMinus_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(lblSpeedChange.Text);
            if (value > 0.1)
                value = value - 0.1;
            lblSpeedChange.Text = value.ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            lblStatusChange.Text = "정지";
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnRight.Enabled = false;
            btnLeft.Enabled = false;

            btnSpeedPlus.Enabled = false;
            btnSpeedMinus.Enabled = false;

            btnWeightPlus.Enabled = true;
            btnWeightMinus.Enabled = true;

            btnStart.Enabled = true;
            btnStop.Enabled = false;

            if (btnAuto.Enabled == false)
            {
                btnManual.Enabled = true;
            }
            else if (btnManual.Enabled == false)
            {
                btnAuto.Enabled = false;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            lblStatusChange.Text = "위로 이동";
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            lblStatusChange.Text = "아래로 이동";
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            lblStatusChange.Text = "왼쪽 이동";
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            lblStatusChange.Text = "오른쪽 이동";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblStatusChange.Text = "시작";
            if (btnManual.Enabled == false)
            {
                btnUp.Enabled = true;
                btnDown.Enabled = true;
                btnRight.Enabled = true;
                btnLeft.Enabled = true;
            }
            btnSpeedPlus.Enabled = true;
            btnSpeedMinus.Enabled = true;
            btnWeightPlus.Enabled = false;
            btnWeightMinus.Enabled = false;

            btnStop.Enabled = true;
            btnStart.Enabled = false;

            btnManual.Enabled = false;
            btnAuto.Enabled = false;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            lblModeChange.Text = "자동모드";
            btnAuto.Enabled = false;
            btnManual.Enabled = true;

            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnRight.Enabled = false;
            btnLeft.Enabled = false;

        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            lblModeChange.Text = "수동모드";
            btnAuto.Enabled = true;
            btnManual.Enabled = false;

            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnRight.Enabled = true;
            btnLeft.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnRight.Enabled = false;
            btnLeft.Enabled = false;
            btnSpeedPlus.Enabled = false;
            btnSpeedMinus.Enabled = false;
            btnStop.Enabled = false;
            btnAuto.Enabled = false;
        }
    }
}
