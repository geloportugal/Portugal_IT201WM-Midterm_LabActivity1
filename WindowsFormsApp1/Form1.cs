using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeFormDefaults();
        }

        private void InitializeFormDefaults()
        {
            txtPagibig.Text = "200.00";

            txtBasicIncome.ReadOnly = true;
            txtHonorIncome.ReadOnly = true;
            txtOtherIncome.ReadOnly = true;
            txtGrossIncome.ReadOnly = true;
            txtTotalDeductions.ReadOnly = true;
            txtNetIncome.ReadOnly = true;
        }

        private decimal GetDecimal(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
                return 0m;

            decimal value;
            if (decimal.TryParse(txt.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out value))
                return value;

            if (decimal.TryParse(txt.Text, out value))
                return value;

            MessageBox.Show($"Invalid numeric input in {txt.Name}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt.Focus();
            throw new Exception("Invalid input");
        }

        private void btnGrossIncome_Click(object sender, EventArgs e)
        {
            try
            {
                decimal basicRate = GetDecimal(txtBasicRate);
                decimal basicHours = GetDecimal(txtBasicHours);
                decimal honorRate = GetDecimal(txtHonorRate);
                decimal honorHours = GetDecimal(txtHonorHours);
                decimal otherRate = GetDecimal(txtOtherRate);
                decimal otherHours = GetDecimal(txtOtherHours);

                decimal basicIncome = basicRate * basicHours;
                decimal honorIncome = honorRate * honorHours;
                decimal otherIncome = otherRate * otherHours;

                decimal grossIncome = basicIncome + honorIncome + otherIncome;

                txtBasicIncome.Text = basicIncome.ToString("N2");
                txtHonorIncome.Text = honorIncome.ToString("N2");
                txtOtherIncome.Text = otherIncome.ToString("N2");
                txtGrossIncome.Text = grossIncome.ToString("N2");

                if (string.IsNullOrWhiteSpace(txtPagibig.Text))
                    txtPagibig.Text = "200.00";
            }
            catch
            {
            }
        }

        private void btnNetIncome_Click(object sender, EventArgs e)
        {
            try
            {
                decimal grossIncome = GetDecimal(txtGrossIncome);

                decimal sss = GetDecimal(txtSSS);
                decimal philHealth = GetDecimal(txtPhilHealth);
                decimal pagibig = GetDecimal(txtPagibig);
                decimal tax = GetDecimal(txtTax);

                decimal sssLoan = GetDecimal(txtSSSLoan);
                decimal pagibigLoan = GetDecimal(txtPagibigLoan);
                decimal facultySavingsDeposit = GetDecimal(txtFacultySavingsDeposit);
                decimal facultySavingsLoan = GetDecimal(txtFacultySavingsLoan);
                decimal salaryLoan = GetDecimal(txtSalaryLoan);
                decimal otherLoans = GetDecimal(txtOtherLoans);

                decimal totalDeductions =
                    sss + philHealth + pagibig + tax +
                    sssLoan + pagibigLoan + facultySavingsDeposit +
                    facultySavingsLoan + salaryLoan + otherLoans;

                decimal netIncome = grossIncome - totalDeductions;

                txtTotalDeductions.Text = totalDeductions.ToString("N2");
                txtNetIncome.Text = netIncome.ToString("N2");
            }
            catch
            {
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
            txtPagibig.Text = "200.00";
            txtBasicRate.Focus();
        }

        private void ClearAllTextBoxes(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }

                if (ctrl.HasChildren)
                {
                    ClearAllTextBoxes(ctrl);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string employeeName = $"{txtFirstName.Text} {txtMiddleName.Text} {txtSurname.Text}".Trim();

            string message =
                "Payroll Summary\n\n" +
                $"Employee No: {txtEmployeeNo.Text}\n" +
                $"Employee Name: {employeeName}\n" +
                $"Department: {txtDepartment.Text}\n" +
                $"Paydate: {txtPaydate.Text}\n\n" +
                $"Basic Income: {txtBasicIncome.Text}\n" +
                $"Honorarium Income: {txtHonorIncome.Text}\n" +
                $"Other Income: {txtOtherIncome.Text}\n" +
                $"Gross Income: {txtGrossIncome.Text}\n\n" +
                $"Total Deductions: {txtTotalDeductions.Text}\n" +
                $"Net Income: {txtNetIncome.Text}";

            MessageBox.Show(message, "Saved Payroll Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update function is ready. You can connect this to a database or file storage if required by your instructor.",
                "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}