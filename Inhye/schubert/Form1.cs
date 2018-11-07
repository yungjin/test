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
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (comboSelect.SelectedIndex == 0)
            {
                MessageBox.Show(comboSelect.Text);
                this.Opacity = 0;
                form2.Show();
            }
            else if (comboSelect.SelectedIndex == 1)
            {
                MessageBox.Show(comboSelect.Text);
                this.Opacity = 0;
                form2.Show();
            }
            else if (comboSelect.SelectedIndex == 2)
            {
                MessageBox.Show(comboSelect.Text);
                this.Opacity = 0;
                form2.Show();
            }
        }
    }
}
