using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Franklin_Mortgage
{
    public partial class Mortgage : Form
    {
        private bool calculationSuccessful = false;

        public Mortgage()
        {
            InitializeComponent();
        }

        private void Mortgage_Load(object sender, EventArgs e)
        {
            SetInitialState();
        }

        private void SetInitialState()
        {
            txtOther.Visible = false;
            lblOtherError.Visible = false;
            lblPrinError.Visible = false;
            lblTermError.Visible = false;
            lblError.Visible = false;
            lblPayment.Visible = false;

            rdo15.Checked = false;
            rdo30.Checked = false;
            rdoOther.Checked = false;
            cmbOther.SelectedIndex = -1;

            txtPrincipal.Text = string.Empty;
            txtOther.Text = string.Empty;

            btnReset.Enabled = false;
            calculationSuccessful = false;

            txtPrincipal.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblPrinError.Visible = false;
            lblTermError.Visible = false;
            lblOtherError.Visible = false;
            lblError.Visible = false;
            lblPayment.Visible = false;

            string errors = "";

            if (!IsPrincipalValid())
            {
                errors += "Principal must contain digits only.\n";
            }

            if (!rdo15.Checked && !rdo30.Checked && !rdoOther.Checked)
            {
                errors += "Please select a loan term.\n";
                lblTermError.Visible = true;
            }
            else if (rdoOther.Checked)
            {
                if (!int.TryParse(txtOther.Text, out int otherTerm) || otherTerm < 5 || otherTerm > 40)
                {
                    errors += "Other term must be a numeric value between 5 and 40.\n";
                    lblOtherError.Visible = true;
                }
            }

            if (cmbOther.SelectedIndex == -1)
            {
                errors += "Please select an interest rate.\n";
            }

            if (!string.IsNullOrEmpty(errors))
            {
                ShowErrorMessage(errors);
                return;
            }

            int numberOfPayments;
            if (rdo15.Checked)
            {
                numberOfPayments = 15 * 12;
            }
            else if (rdo30.Checked)
            {
                numberOfPayments = 30 * 12;
            }
            else
            {
                numberOfPayments = int.Parse(txtOther.Text) * 12;
            }

            decimal interestRate = decimal.Parse(cmbOther.Text);
            decimal totalPayment = CalculateTotalPayment(decimal.Parse(txtPrincipal.Text), interestRate / 100 / 12, numberOfPayments);

            lblPayment.Text = $"Your total monthly payment will be: {totalPayment:C}";
            lblPayment.Visible = true;

            btnReset.Enabled = true;
            calculationSuccessful = true;
        }

        private void ShowErrorMessage(string errorMessage)
        {
            lblError.Text = errorMessage;
            lblError.Visible = true;
        }

        private decimal CalculateTotalPayment(decimal principal, decimal interestRate, int numberOfPayments)
        {
            double powerResult = Math.Pow(1 + (double)interestRate, -numberOfPayments);
            decimal result = (decimal)powerResult;
            return principal * (interestRate * result) / (1 - result);
        }

        private bool IsPrincipalValid()
        {
            if (!decimal.TryParse(txtPrincipal.Text, out _) || !txtPrincipal.Text.All(char.IsDigit))
            {
                lblPrinError.Visible = true;
                return false;
            }

            lblPrinError.Visible = false;
            return true;
        }

        private void rdoOther_CheckedChanged(object sender, EventArgs e)
        {
            txtOther.Visible = rdoOther.Checked;
            lblOtherError.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetInitialState();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrincipal_TextChanged(object sender, EventArgs e)
        {
            IsPrincipalValid();
        }
    }
}
