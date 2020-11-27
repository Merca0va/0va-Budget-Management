using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Master_2020
{
    public partial class Settings : UserControl
    {
        public Settings()
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

            if (CultureInfo.CurrentCulture.Equals("fr-FR"))
            {
                dashboard.TopLevel = false;
                this.Controls.Add(dashboard);
                dashboard.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                dashboard.Dock = DockStyle.Fill;

                if (MainHeader.ForeColor == Color.Orange)
                {
                    dashboard.ChangeTheme();
                }

                dashboard.ChangeLanguage("fr-FR");
                dashboard.ChangeTheme();
                dashboard.Show();
            }

            else if (CultureInfo.CurrentCulture.Equals("es-ES"))
            {
                dashboard.TopLevel = false;
                this.Controls.Add(dashboard);
                dashboard.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                dashboard.Dock = DockStyle.Fill;

                if (MainHeader.ForeColor == Color.Orange)
                {
                    dashboard.ChangeTheme();
                }

                dashboard.ChangeLanguage("es-ES");
                dashboard.ChangeTheme();
                dashboard.Show();
            }

            else
            {
                dashboard.TopLevel = false;
                this.Controls.Add(dashboard);
                dashboard.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                dashboard.Dock = DockStyle.Fill;

                if (MainHeader.ForeColor == Color.Orange)
                {
                    dashboard.ChangeTheme();
                }

                dashboard.ChangeLanguage("en");
                dashboard.Show();
            }

        }

        private void IncomeButton_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            Income income = new Income();

            if (CultureInfo.CurrentCulture.Equals("fr-FR"))
            {
                this.Controls.Clear();
                income.Dock = DockStyle.Fill;
                this.Controls.Add(income);

                if (MainHeader.ForeColor == Color.Orange)
                {
                    income.ChangeTheme();
                }

                income.ChangeLanguage("fr-FR");
            }

            else if (CultureInfo.CurrentCulture.Equals("es-ES"))
            {
                this.Controls.Clear();
                income.Dock = DockStyle.Fill;
                this.Controls.Add(income);

                if (MainHeader.ForeColor == Color.Orange)
                {
                    income.ChangeTheme();
                }

                income.ChangeLanguage("es-ES");
            }

            else
            {
                this.Controls.Clear();
                income.Dock = DockStyle.Fill;
                this.Controls.Add(income);

                if (MainHeader.ForeColor == Color.Orange)
                {
                    income.ChangeTheme();
                }

                income.ChangeLanguage("en");
            }
        }

        private void ExpensesButton_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            Expenses expenses = new Expenses();

            if (CultureInfo.CurrentCulture.Equals("fr-FR"))
            {
                this.Controls.Clear();
                expenses.Dock = DockStyle.Fill;
                this.Controls.Add(expenses);

                if (MainHeader.ForeColor == Color.Orange)
                {
                    expenses.ChangeTheme();
                }

                expenses.ChangeLanguage("fr-FR");
            }

            else if (CultureInfo.CurrentCulture.Equals("es-ES"))
            {
                this.Controls.Clear();
                expenses.Dock = DockStyle.Fill;
                this.Controls.Add(expenses);

                if (MainHeader.ForeColor == Color.Orange)
                {
                    expenses.ChangeTheme();
                }

                expenses.ChangeLanguage("es-ES");
            }

            else
            {
                this.Controls.Clear();
                expenses.Dock = DockStyle.Fill;
                this.Controls.Add(expenses);

                if (MainHeader.ForeColor == Color.Orange)
                {
                    expenses.ChangeTheme();
                }

                expenses.ChangeLanguage("en");
            }
        }

        private void StatementButton_Click(object sender, EventArgs e)
        {
                MoveIndicator((Control)sender);
                Statements statements = new Statements();

            if (CultureInfo.CurrentCulture.Equals("fr-FR"))
            {               
                this.Controls.Clear();
                statements.Dock = DockStyle.Fill;
                this.Controls.Add(statements);

                if (MainHeader.ForeColor == Color.Orange)
                {
                    statements.ChangeTheme();
                    statements.ChangeLanguage("fr-FR");
                }

                statements.ChangeLanguage("fr-FR");
            }

            else if (CultureInfo.CurrentCulture.Equals("es-ES"))
            {
                this.Controls.Clear();
                statements.Dock = DockStyle.Fill;
                this.Controls.Add(statements);

                if (MainHeader.ForeColor == Color.Orange)
                {
                    statements.ChangeTheme();
                    statements.ChangeLanguage("es-ES");
                }

                statements.ChangeLanguage("es-ES");
            }

            else
            {
                this.Controls.Clear();
                statements.Dock = DockStyle.Fill;
                this.Controls.Add(statements);

                if (MainHeader.ForeColor == Color.Orange)
                {
                    statements.ChangeTheme();
                    statements.ChangeLanguage("en");
                }

                statements.ChangeLanguage("en");
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
        }

        private void MapButton_Click(object sender, EventArgs e)
        {
            MapPoints map = new MapPoints();

            if (MainHeader.ForeColor == Color.Orange)
            {
                map.ChangeTheme();
                map.ShowDialog();
            }

            else
            {
                map.ShowDialog();
            }
        }

        public void ApplyButton_Click(object sender, EventArgs e)
        {
            Index1 dashboard = new Index1();
            Income income = new Income();
            Expenses expenses = new Expenses();
            Statements statements = new Statements();

            if ( EnglishCheck.Checked == true)
            {
                ChangeLanguage("en");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            }

            else if (FrenchCheck.Checked == true)
            {
                ChangeLanguage("fr-FR");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
            }

            else if (SpanishCheck.Checked == true)
            {
                ChangeLanguage("es-ES");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            }

            if(ThemeBox.SelectedIndex == 1)
            {
                TangerineTheme();
            }

            else if(ThemeBox.SelectedIndex == 0)
            {
                OrchidTheme();
            }
        }

        public void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager ResourceManager = new ComponentResourceManager(typeof(Settings));
                ResourceManager.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        public void TangerineTheme()
        {
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
            CategoryLab1.ForeColor = Color.Orange;
            CategoryLab2.ForeColor = Color.Orange;
            pictureBox4.BackColor = Color.Orange;
            pictureBox2.BackColor = Color.Orange;
            SystemLab1.BackColor = Color.Orange;
            SystemLab1.ForeColor = Color.SaddleBrown;
            MapButton.BackColor = Color.Orange;
            DisplayLab1.BackColor = Color.Orange;
            DisplayLab1.ForeColor = Color.SaddleBrown;
            DisplayLab2.BackColor = Color.Orange;
            DisplayLab2.ForeColor = Color.SaddleBrown;
            LanguageLab.BackColor = Color.Orange;
            LanguageLab.ForeColor = Color.SaddleBrown;
            EnglishCheck.BackColor = Color.Orange;
            EnglishCheck.ForeColor = Color.SaddleBrown;
            FrenchCheck.BackColor = Color.Orange;
            FrenchCheck.ForeColor = Color.SaddleBrown;
            SpanishCheck.BackColor = Color.Orange;
            SpanishCheck.ForeColor = Color.SaddleBrown;
            AppearanceLab.BackColor = Color.Orange;
            AppearanceLab.ForeColor = Color.SaddleBrown;
            ApplyButton.BackColor = Color.Orange;
            ApplyButton.ForeColor = Color.SaddleBrown;
        }

        public void OrchidTheme()
        {
            MainHeader.ForeColor = Color.DarkOrchid;
            pictureBox1.Image = Properties.Resources.LotusLogo2;
            HighHeader.BackColor = Color.DarkOrchid;
            panel2.BackColor = Color.DarkOrchid;
            panel3.BackColor = Color.DarkOrchid;
            DashboardButton.BackColor = Color.DarkOrchid;
            DashboardButton.ForeColor = Color.Black;
            IncomeButton.BackColor = Color.DarkOrchid;
            IncomeButton.ForeColor = Color.Black;
            ExpensesButton.BackColor = Color.DarkOrchid;
            ExpensesButton.ForeColor = Color.Black;
            StatementButton.BackColor = Color.DarkOrchid;
            StatementButton.ForeColor = Color.Black;
            SettingsButton.BackColor = Color.DarkOrchid;
            SettingsButton.ForeColor = Color.Black;
            Indicator.BackColor = Color.Black;
            CategoryLab1.ForeColor = Color.DarkOrchid;
            CategoryLab2.ForeColor = Color.DarkOrchid;
            pictureBox4.BackColor = Color.DarkOrchid;
            pictureBox2.BackColor = Color.DarkOrchid;
            SystemLab1.BackColor = Color.DarkOrchid;
            SystemLab1.ForeColor = Color.Black;
            MapButton.BackColor = Color.DarkOrchid;
            DisplayLab1.BackColor = Color.DarkOrchid;
            DisplayLab1.ForeColor = Color.Black;
            DisplayLab2.BackColor = Color.DarkOrchid;
            DisplayLab2.ForeColor = Color.Black;
            LanguageLab.BackColor = Color.DarkOrchid;
            LanguageLab.ForeColor = Color.Black;
            EnglishCheck.BackColor = Color.DarkOrchid;
            EnglishCheck.ForeColor = Color.Black;
            FrenchCheck.BackColor = Color.DarkOrchid;
            FrenchCheck.ForeColor = Color.Black;
            SpanishCheck.BackColor = Color.DarkOrchid;
            SpanishCheck.ForeColor = Color.Black;
            AppearanceLab.BackColor = Color.DarkOrchid;
            AppearanceLab.ForeColor = Color.Black;
            ApplyButton.BackColor = Color.DarkOrchid;
            ApplyButton.ForeColor = Color.Black;
        }
    }
}
