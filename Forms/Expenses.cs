using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Master_2020
{
    public partial class Expenses : UserControl
    {
        public Expenses()
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
            Settings settings = new Settings();
            this.Controls.Clear();
            settings.Dock = DockStyle.Fill;
            this.Controls.Add(settings);

            if (MainHeader.ForeColor == Color.Orange)
            {
                settings.TangerineTheme();
            }
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            //Start by creating an instance of SQLConnection class.
            SqlConnection myCon = new SqlConnection(@"Data Source = (local)\SQLEXPRESS;
                                                     Initial Catalog = BudgetManagement_DB;
                                                     Integrated Security = True;");

            //Stream data across the SqlConnection pipe.
            SqlDataAdapter myDA = new SqlDataAdapter("select Expense_ID, transaction_Date, Payment_To, Amount, Expense_Description from Expenses", myCon);

            //Create a dataTable instance to hold the stream of data.
            DataTable myTable = new DataTable();

            //Move the stream of data through the pipe and format it as a database table.
            myDA.Fill(myTable);

            ExpensesGrid.DataSource = myTable;
        }

        public void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager ResourceManager = new ComponentResourceManager(typeof(Expenses));
                ResourceManager.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        public void ChangeTheme()
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
            label1.ForeColor = Color.Brown;
            ExpensesGrid.GridColor = Color.SaddleBrown;
            ExpensesGrid.DefaultCellStyle.BackColor = Color.SaddleBrown;
            ExpensesGrid.DefaultCellStyle.ForeColor = Color.DarkRed;
            ExpensesGrid.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            ExpensesGrid.RowHeadersDefaultCellStyle.BackColor = Color.SaddleBrown;
            ExpensesGrid.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            ExpensesGrid.RowsDefaultCellStyle.BackColor = Color.Chocolate;
            ExpensesGrid.RowsDefaultCellStyle.ForeColor = Color.DarkRed;
            ExpensesGrid.RowsDefaultCellStyle.SelectionBackColor = Color.Yellow;
            ExpensesGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.Chocolate;
            ExpensesGrid.AlternatingRowsDefaultCellStyle.ForeColor = Color.DarkRed;
            ExpensesGrid.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Yellow;
        }
    }
}
