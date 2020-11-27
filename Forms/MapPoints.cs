using DotNetBrowser;
using DotNetBrowser.WinForms;
using DotNetBrowser.WinForms.ContextMenu;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Budget_Master_2020
{
    public partial class MapPoints : Form
    {
        public MapPoints()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string area = textBox1.Text;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("http://maps.google.com/maps?q=");

            if (area != string.Empty)
            {
                stringBuilder.Append("cash point " + area + "," + "+");
            }

            webBrowser1.Navigate(stringBuilder.ToString());
        }

        public void ChangeTheme()
        {
            pictureBox1.Image = Properties.Resources.search_3_48px;
            panel1.BackColor = Color.DarkOrange;
            label1.ForeColor = Color.DarkOrange;
            textBox1.ForeColor = Color.SaddleBrown;
        }
    }
}
