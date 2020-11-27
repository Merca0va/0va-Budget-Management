using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace Budget_Master_2020
{
    public partial class Index1 : Form
    {
        Settings settings = new Settings();
        public Index1()
        {
            InitializeComponent();
        }

        void MoveIndicator(Control bt)
        {
            Indicator.Left = bt.Left;
            Indicator.Width = bt.Width;
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
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
            Statements statements = new Statements();
            this.Controls.Clear();
            statements.Dock = DockStyle.Fill;
            this.Controls.Add(statements);

            if (MainHeader.ForeColor == Color.Orange)
            {
                statements.ChangeTheme();
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            this.Controls.Clear();
            settings.Dock = DockStyle.Fill;
            this.Controls.Add(settings);

            if (MainHeader.ForeColor == Color.Orange)
            {
                settings.TangerineTheme();
            }
        }

        private void AnalysisBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (AnalysisBox.SelectedIndex == 0)
            {
                foreach (var series in GeneralChart.Series)
                {
                    series.Points.Clear();
                }

                GeneralChart.Series["Income"].Points.AddXY(1, 1800);
                GeneralChart.Series["Balance"].Points.AddXY(1, 4358);
                GeneralChart.Series["Expense"].Points.AddXY(1, 42);

                GeneralChart.Series["Balance"].Points.AddXY(3, 4355);
                GeneralChart.Series["Expense"].Points.AddXY(3, 3);

                GeneralChart.Series["Balance"].Points.AddXY(4, 4335);
                GeneralChart.Series["Expense"].Points.AddXY(4, 20);

                GeneralChart.Series["Balance"].Points.AddXY(5, 4324);
                GeneralChart.Series["Expense"].Points.AddXY(5, 11);

                GeneralChart.Series["Income"].Points.AddXY(9, 65);
                GeneralChart.Series["Balance"].Points.AddXY(9, 4366);
                GeneralChart.Series["Expense"].Points.AddXY(9, 23);

                GeneralChart.Series["Balance"].Points.AddXY(10, 4348);
                GeneralChart.Series["Expense"].Points.AddXY(10, 18);

                GeneralChart.Series["Balance"].Points.AddXY(12, 4342);
                GeneralChart.Series["Expense"].Points.AddXY(12, 6);

                GeneralChart.Series["Balance"].Points.AddXY(13, 4339);
                GeneralChart.Series["Expense"].Points.AddXY(13, 3);

                GeneralChart.Series["Income"].Points.AddXY(16, 255);
                GeneralChart.Series["Balance"].Points.AddXY(16, 4533);
                GeneralChart.Series["Expense"].Points.AddXY(16, 58);

                GeneralChart.Series["Balance"].Points.AddXY(17, 4250);
                GeneralChart.Series["Expense"].Points.AddXY(17, 283);

                GeneralChart.Series["Balance"].Points.AddXY(18, 4235);
                GeneralChart.Series["Expense"].Points.AddXY(18, 15);

                GeneralChart.Series["Balance"].Points.AddXY(19, 4229);
                GeneralChart.Series["Expense"].Points.AddXY(19, 6);

                GeneralChart.Series["Balance"].Points.AddXY(20, 4220);
                GeneralChart.Series["Expense"].Points.AddXY(20, 9);

                GeneralChart.Series["Balance"].Points.AddXY(24, 3511);
                GeneralChart.Series["Expense"].Points.AddXY(24, 709);

                GeneralChart.Series["Income"].Points.AddXY(27, 156);
                GeneralChart.Series["Balance"].Points.AddXY(27, 3667);


                foreach(var series in IncomeChart.Series)
                {
                    series.Points.Clear();
                }
                IncomeChart.Series["Income"].Points.AddXY("Salary", 1800);
                IncomeChart.Series["Income"].Points.AddXY("Freelance", 475);



                foreach (var series in ExpenseChart.Series)
                {
                    series.Points.Clear();
                }
                ExpenseChart.Series["Expenses"].Points.AddXY("Rent", 700);
                ExpenseChart.Series["Expenses"].Points.AddXY("Transport", 69);
                ExpenseChart.Series["Expenses"].Points.AddXY("Grosseries", 110);
                ExpenseChart.Series["Expenses"].Points.AddXY("Hobbies", 93);
                ExpenseChart.Series["Expenses"].Points.AddXY("Others", 234);

                BalanceLabel.Text = "£3,667.00";
                IncomeLabel.Text = "£2,275.00";
                ExpenseLabel.Text = "£1,206.00";
            }

            if (AnalysisBox.SelectedIndex == 1)
            {
                foreach (var series in GeneralChart.Series)
                {
                    series.Points.Clear();
                }


                GeneralChart.Series["Income"].Points.AddXY(1, 1800);
                GeneralChart.Series["Balance"].Points.AddXY(1, 4324);
                GeneralChart.Series["Expense"].Points.AddXY(1, 76);

                GeneralChart.Series["Income"].Points.AddXY(2, 64);
                GeneralChart.Series["Balance"].Points.AddXY(2, 4339);
                GeneralChart.Series["Expense"].Points.AddXY(2, 50);

                GeneralChart.Series["Income"].Points.AddXY(3, 255);
                GeneralChart.Series["Balance"].Points.AddXY(3, 4220);
                GeneralChart.Series["Expense"].Points.AddXY(3, 371);

                GeneralChart.Series["Income"].Points.AddXY(4, 156);
                GeneralChart.Series["Balance"].Points.AddXY(4, 3667);
                GeneralChart.Series["Expense"].Points.AddXY(4, 709);


                foreach (var series in IncomeChart.Series)
                {
                    series.Points.Clear();
                }
                IncomeChart.Series["Income"].Points.AddXY("Salary", 1800);
                IncomeChart.Series["Income"].Points.AddXY("Freelance", 475);


                foreach (var series in ExpenseChart.Series)
                {
                    series.Points.Clear();
                }
                ExpenseChart.Series["Expenses"].Points.AddXY("Rent", 700);
                ExpenseChart.Series["Expenses"].Points.AddXY("Transport", 69);
                ExpenseChart.Series["Expenses"].Points.AddXY("Grosseries", 110);
                ExpenseChart.Series["Expenses"].Points.AddXY("Hobbies", 93);
                ExpenseChart.Series["Expenses"].Points.AddXY("Others", 234);

                BalanceLabel.Text = "£3,667.00";
                IncomeLabel.Text = "£2,275.00";
                ExpenseLabel.Text = "£1,206.00";
            }

            if (AnalysisBox.SelectedIndex == 2)
            {
               foreach(var series in GeneralChart.Series)
                {
                    series.Points.Clear();
                }

                GeneralChart.Series["Income"].Points.AddXY(1, 2275);
                GeneralChart.Series["Balance"].Points.AddXY(1, 3667);
                GeneralChart.Series["Expense"].Points.AddXY(1, 1206);


                foreach (var series in IncomeChart.Series)
                {
                    series.Points.Clear();
                }
                IncomeChart.Series["Income"].Points.AddXY("Salary", 1800);
                IncomeChart.Series["Income"].Points.AddXY("Freelance", 475);


                foreach (var series in ExpenseChart.Series)
                {
                    series.Points.Clear();
                }

                ExpenseChart.Series["Expenses"].Points.AddXY("Rent", 700);
                ExpenseChart.Series["Expenses"].Points.AddXY("Transport", 69);
                ExpenseChart.Series["Expenses"].Points.AddXY("Grosseries", 110);
                ExpenseChart.Series["Expenses"].Points.AddXY("Hobbies", 93);
                ExpenseChart.Series["Expenses"].Points.AddXY("Others", 234);

                BalanceLabel.Text = "£3,667.00";
                IncomeLabel.Text = "£2,275.00";
                ExpenseLabel.Text = "£1,206.00";
            }

            if (MainHeader.ForeColor == Color.Orange)
            {
                GeneralChart.Series["Income"].Color = Color.Yellow;
                GeneralChart.Series["Balance"].Color = Color.DarkOrange;
                GeneralChart.Series["Expense"].Color = Color.Red;

                IncomeChart.Series["Income"].Color = Color.Gold;
                IncomeChart.Series["Income"].Color = Color.Goldenrod;

                ExpenseChart.Series["Expenses"].Color = Color.LightSalmon;
                ExpenseChart.Series["Expenses"].Color = Color.Tomato;
                ExpenseChart.Series["Expenses"].Color = Color.Chocolate;
                ExpenseChart.Series["Expenses"].Color = Color.IndianRed;
                ExpenseChart.Series["Expenses"].Color = Color.DarkRed;
            }

            GeneralChart.Series["Income"].Color = Color.Purple;
            GeneralChart.Series["Balance"].Color = Color.BlueViolet;
            GeneralChart.Series["Expense"].Color = Color.Magenta;

        }

        private void Index1_Load(object sender, EventArgs e)
        {
            
        }

        public void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager ResourceManager = new ComponentResourceManager(typeof(Index1));
                ResourceManager.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        public void ChangeTheme()
        {
            MainHeader.ForeColor = Color.Orange;
            pictureBox1.Image = Properties.Resources.LotusLogo4;
            HighHeader.BackColor = Color.Orange;
            panel1.BackColor = Color.AntiqueWhite;
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
            label5.BackColor = Color.Black;
            label5.ForeColor = Color.Gold;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.Gold;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.Gold;
            pictureBox5.BackColor = Color.Gold;
            label7.BackColor = Color.Gold;
            label7.ForeColor = Color.Linen;
            pictureBox9.BackColor = Color.Gold;
            label10.BackColor = Color.Gold;
            label10.ForeColor = Color.Linen;
            pictureBox10.BackColor = Color.Gold;
            label11.BackColor = Color.Gold;
            label11.ForeColor = Color.Linen;
            AnalysisBox.BackColor = Color.SandyBrown;
            AnalysisBox.ForeColor = Color.SaddleBrown;
            pictureBox2.Image = Properties.Resources.money_pound_48px;
            pictureBox3.Image = Properties.Resources.price_tag_pound_48px;
            pictureBox4.Image = Properties.Resources.Gold_exchange_pound_50px;
            GeneralChart.Series["Income"].Color = Color.Yellow;
            GeneralChart.Series["Balance"].Color = Color.DarkOrange;
            GeneralChart.Series["Expense"].Color = Color.Red;
            IncomeChart.Series["Income"].Color = Color.Gold;
            IncomeChart.Series["Income"].Color = Color.Goldenrod;
            ExpenseChart.Series["Expenses"].Color = Color.LightSalmon;
            ExpenseChart.Series["Expenses"].Color = Color.Tomato;
            ExpenseChart.Series["Expenses"].Color = Color.Chocolate;
            ExpenseChart.Series["Expenses"].Color = Color.IndianRed;
            ExpenseChart.Series["Expenses"].Color = Color.DarkRed;
        }
    }
}
