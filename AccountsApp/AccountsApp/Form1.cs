using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class fAccounts : Form
    {
        private List<Account> accounts = new List<Account>();
       
        public fAccounts()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fAccounts_Load(object sender, EventArgs e)
        {
            accounts.Add(new CheckingAccount(12, "Terrie", 30, 50000));

            accounts.Add(new VisaAccount(08, "Jamie", 88000, 48));
        }

        private void rbChecking_CheckedChanged(object sender, EventArgs e)
        {
            txtWithdraw.Enabled = rbChecking.Checked;
            txtInterest.Enabled = rbVisa.Checked;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = null;

                int number = Convert.ToInt32(txtNumber.Text);

                if (txtName.Text == string.Empty)
                    throw new Exception("Name cannot be empty!");

                string name = txtName.Text;

                double balance = Convert.ToDouble(txtBalance.Text);

                if (accounts.Exists(x => x.Number == number))
                {
                    //if account already exists
                    MessageBox.Show("Account number already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                // rbChecking.checked

                if (rbChecking.Checked)
                {
                    double withdrawLimit = Convert.ToDouble(txtWithdraw.Text);

                    //create checking account
                    account = new CheckingAccount(number, name, balance, withdrawLimit);

                    //store in the account
                    account.IsCheckingAccount = true;
                }

                else if (rbVisa.Checked)
                {
                    double interestRate = Convert.ToDouble(txtInterest.Text);

                    //create visa account
                    account = new VisaAccount(number, name, balance, interestRate);

                    //store in the account 
                    account.IsCheckingAccount = false;

                }

                //if != null
                if (account != null)
                {
                    //add account
                    accounts.Add(account);

                    //clear controls
                    txtName.Text = "";
                    txtNumber.Text = "";
                    txtBalance.Text = "";
                    txtWithdraw.Text = "";
                    txtInterest.Text = "";

                    //disaplay error message
                    MessageBox.Show("Number of account stored: " + accounts.Count, "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //bonus
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int accountNumber = Convert.ToInt32(txtNumber.Text);

                // find account exists
                Account account = accounts.Find(x => x.Number == accountNumber);

                //if account != null
                if (account != null)
                {
                    txtName.Text = account.ClientName;
                    txtBalance.Text = account.Balance.ToString();

                    // if account.IsCheckingAccount == true
                    if (account.IsCheckingAccount == true)
                    {
                        txtWithdraw.Text = ((CheckingAccount)account).WithdrawLimit.ToString();
                    }

                    else if (account.IsCheckingAccount == false)
                    {
                        txtInterest.Text = ((VisaAccount)account).InterestRate.ToString();
                    }
                }

                //display error message, if account not found
                else
                    MessageBox.Show("Account not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    }

