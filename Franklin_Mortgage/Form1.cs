using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Franklin_Mortgage
{
    public partial class Mortgage : Form
    {
        public Mortgage()
        {
            InitializeComponent();
        }

        private void Mortgage_Load(object sender, EventArgs e)
        {
            txtOther.Visible = false;
            lblOtherError.Visible = false;
            txtPrincipal.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblPrinError.Visible = false;
            lblOtherError.Visible = false;

            if (!decimal.TryParse(txtPrincipal.Text, out decimal principal) || principal <= 0)
            {
                lblPrinError.Visible = true;
                txtPrincipal.Focus();
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
                if (!int.TryParse(txtOther.Text, out numberOfPayments))
                {
                    lblOtherError.Visible = true;
                    txtOther.Focus();
                    return;
                }
                numberOfPayments *= 12;
            }

            decimal interestRate;
            if (!decimal.TryParse(cmbOther.Text, out interestRate))
            {
                MessageBox.Show("Please select a valid interest rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbOther.Focus();
                return;
            }

            decimal totalPayment = CalculateTotalPayment(principal, interestRate / 100 / 12, numberOfPayments);

            lblPayment.Text = $"Your total monthly payment will be: {totalPayment:C}";
        }
        private decimal CalculateTotalPayment(decimal principal, decimal interestRate, int numberOfPayments)
        {
            double powerResult = Math.Pow(1 + (double)interestRate, -numberOfPayments);
            decimal result = (decimal)powerResult;
            return principal * (interestRate * result) / (1 - result);
        }

        private void rdoOther_CheckedChanged(object sender, EventArgs e)
        {
            txtOther.Visible = rdoOther.Checked;
            lblOtherError.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = string.Empty;
            rdo15.Checked = false;
            rdo30.Checked = true;
            rdoOther.Checked = false;
            txtOther.Text = string.Empty;
            txtOther.Visible = false;
            cmbOther.SelectedIndex = 0;
            lblPrinError.Visible = false;
            lblOtherError.Visible = false;

            txtPrincipal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
