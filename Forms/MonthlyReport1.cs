using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Master_2020
{
    public partial class MonthlyReport1 : Form
    {
        public MonthlyReport1()
        {
            InitializeComponent();
        }

        public void ChangeTheme()
        {
            MainHeader.ForeColor = Color.Orange;
            pictureBox1.Image = Properties.Resources.LotusLogo4;
            pictureBox2.BackColor = Color.DarkOrange;
            pictureBox3.BackColor = Color.DarkSalmon;
            label1.ForeColor = Color.LightGoldenrodYellow;
            label1.BackColor = Color.DarkOrange;
            label2.ForeColor = Color.LightGoldenrodYellow;
            label2.BackColor = Color.DarkOrange;
            label3.ForeColor = Color.DarkSalmon;
            label4.ForeColor = Color.DarkSalmon;
            label5.ForeColor = Color.DarkSalmon;
            label6.ForeColor = Color.DarkSalmon;
            label7.ForeColor = Color.DarkSalmon;
        }
    }
}
