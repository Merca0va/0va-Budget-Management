using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Master_2020
{
    public partial class Statements : UserControl
    {
        public Statements()
        {
            InitializeComponent();
        }

        void MoveIndicator(Control bt)
        {
            Indicator.Left = bt.Left;
            Indicator.Width = bt.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            Index1 dashboard = new Index1();
            dashboard.TopLevel = false;
            this.Controls.Add(dashboard);
            dashboard.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard.Dock = DockStyle.Fill;

            if (MainHeader.ForeColor == Color.Orange)
            {
                dashboard.ChangeTheme();
            }

            dashboard.Show();
        }

        private void IncomeButton_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            Income income = new Income();
            this.Controls.Clear();
            income.Dock = DockStyle.Fill;
            this.Controls.Add(income);

            if (MainHeader.ForeColor == Color.Orange)
            {
                income.ChangeTheme();
            }
        }

        private void ExpensesButton_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            Expenses expenses = new Expenses();
            this.Controls.Clear();
            expenses.Dock = DockStyle.Fill;
            this.Controls.Add(expenses);

            if (MainHeader.ForeColor == Color.Orange)
            {
                expenses.ChangeTheme();
            }
        }

        private void StatementButton_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            Settings settings = new Settings();
            this.Controls.Clear();
            settings.Dock = DockStyle.Fill;
            this.Controls.Add(settings);

            if (MainHeader.ForeColor == Color.Orange)
            {
                settings.TangerineTheme();
            }
        }

        private void Link1Report1_Click(object sender, EventArgs e)
        {
            if (MainHeader.ForeColor == Color.Orange)
            {
                DailyReport1 report1 = new DailyReport1();
                report1.ChangeTheme();
                report1.ShowDialog();
            }

            else
            {
                DailyReport1 report1 = new DailyReport1();
                report1.ShowDialog();
            }
        }

        private void Link2Report1_Click(object sender, EventArgs e)
        {
            DailyReport1 report1 = new DailyReport1();

            if (MainHeader.ForeColor == Color.Orange)
            {
                report1.ChangeTheme();
                report1.ShowDialog();
            }

            else
            {
                report1.ShowDialog();
            }
        }

        private void Link1Report2_Click(object sender, EventArgs e)
        {


            DailyReport2 report2 = new DailyReport2();

            if (MainHeader.ForeColor == Color.Orange)
            {
                report2.ChangeTheme();
                report2.ShowDialog();
            }

            else
            {
                report2.ShowDialog();
            }
        }

        private void Link2Report2_Click(object sender, EventArgs e)
        {
            DailyReport2 report2 = new DailyReport2();

            if (MainHeader.ForeColor == Color.Orange)
            {
                report2.ChangeTheme();
                report2.ShowDialog();
            }

            else
            {
                report2.ShowDialog();
            }
        }

        private void Link1Report3_Click(object sender, EventArgs e)
        {
            DailyReport3 report3 = new DailyReport3();

            if (MainHeader.ForeColor == Color.Orange)
            {
                report3.ChangeTheme();
                report3.ShowDialog();
            }

            else
            {
                report3.ShowDialog();
            }
        }

        private void Link2Report3_Click(object sender, EventArgs e)
        {
            DailyReport3 report3 = new DailyReport3();

            if (MainHeader.ForeColor == Color.Orange)
            {
                report3.ChangeTheme();
                report3.ShowDialog();
            }

            else
            {
                report3.ShowDialog();
            }
        }

        private void Link1Report4_Click(object sender, EventArgs e)
        {
            Weekly_Report_1 report4 = new Weekly_Report_1();

            if (MainHeader.ForeColor == Color.Orange)
            {
                report4.ChangeTheme();
                report4.ShowDialog();
            }
            else
            {
                report4.ShowDialog();
            }
        }

        private void Link2Report4_Click(object sender, EventArgs e)
        {
            Weekly_Report_1 report4 = new Weekly_Report_1();

            if (MainHeader.ForeColor == Color.Orange)
            {
                report4.ChangeTheme();
                report4.ShowDialog();
            }
            else
            {
                report4.ShowDialog();
            }
        }

        private void Link1Report7_Click(object sender, EventArgs e)
        {
            MonthlyReport1 report5 = new MonthlyReport1();

            if (MainHeader.ForeColor == Color.Orange)
            {
                report5.ChangeTheme();
                report5.ShowDialog();
            }

            else
            {
                report5.ShowDialog();
            }
        }

        private void Link2Report7_Click(object sender, EventArgs e)
        {
            MonthlyReport1 report5 = new MonthlyReport1();

            if (MainHeader.ForeColor == Color.Orange)
            {
                report5.ChangeTheme();
                report5.ShowDialog();
            }

            else
            {
                report5.ShowDialog();
            }
        }

        public void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager ResourceManager = new ComponentResourceManager(typeof(Statements));
                ResourceManager.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        public void ChangeTheme()
        {
            Link1Report1.Image = Properties.Resources.report_card_3_50px;
            Link1Report2.Image = Properties.Resources.report_card_3_50px;
            Link1Report3.Image = Properties.Resources.report_card_3_50px;
            Link1Report4.Image = Properties.Resources.report_card_3_50px;
            Link1Report7.Image = Properties.Resources.report_card_3_50px;
            MainHeader.ForeColor = Color.Orange;
            pictureBox1.Image = Properties.Resources.LotusLogo4;
            HighHeader.BackColor = Color.Orange;
            panel2.BackColor = Color.Orange;
            panel3.BackColor = Color.Orange;
            DashboardButton.BackColor = Color.Orange;
            DashboardButton.ForeColor = Color.AntiqueWhite;
            IncomeButton.BackColor = Color.Orange;
            IncomeButton.ForeColor = Color.AntiqueWhite;
            ExpensesButton.BackColor = Color.Orange;
            ExpensesButton.ForeColor = Color.AntiqueWhite;
            StatementButton.BackColor = Color.Orange;
            StatementButton.ForeColor = Color.AntiqueWhite;
            SettingsButton.BackColor = Color.Orange;
            SettingsButton.ForeColor = Color.AntiqueWhite;
            Indicator.BackColor = Color.AntiqueWhite;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.DarkRed;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.DarkRed;
            label6.BackColor = Color.Black;
            label6.ForeColor = Color.DarkRed;
            Link2Report1.BackColor = Color.Black;
            Link2Report1.ForeColor = Color.OrangeRed;
            Link2Report2.BackColor = Color.Black;
            Link2Report2.ForeColor = Color.OrangeRed;
            Link2Report3.BackColor = Color.Black;
            Link2Report3.ForeColor = Color.OrangeRed;
            Link2Report4.BackColor = Color.Black;
            Link2Report4.ForeColor = Color.OrangeRed;
            Link2Report7.BackColor = Color.Black;
            Link2Report7.ForeColor = Color.OrangeRed;
        }
    }
}
