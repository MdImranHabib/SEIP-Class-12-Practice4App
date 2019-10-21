using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankAccount
{
    public partial class BankAccountUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            string accountNo = inputAccountNo.Value;
            string accountName = inputAccountName.Value;

            if(accountNo.Length > 3)
            {
                if(accountName.Length > 0)
                {
                    Account account = new Account(accountNo, accountName);
                    ViewState["Account"] = account;
                    lblShowAccountCreateMsg.InnerText = "Account Created Successfully!";
                }
                else
                {
                    lblShowAccountCreateMsg.InnerText = "Account Name can not be null";
                }
            }
            else
            {
                lblShowAccountCreateMsg.InnerText = "Account No must be greater than 3 chararcters";
            }


        }

        protected void btnDeposit_Click(object sender, EventArgs e)
        {
            Account aAccount = (Account) ViewState["Account"];

            double amount =Convert.ToDouble(inputAmount.Value);
            string message = aAccount.Deposite(amount);
            lblShowTransactionMsg.InnerText = message;
        }

        protected void btnWithdraw_Click(object sender, EventArgs e)
        {
            Account aAccount = (Account)ViewState["Account"];

            double amount = Convert.ToDouble(inputAmount.Value);
            string message = aAccount.Withdraw(amount);
            lblShowTransactionMsg.InnerText = message;
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            Account aAccount = (Account)ViewState["Account"];

            if (aAccount == null)
            {
                lblReport.InnerText = "There is no data!";
                return;
            }

            lblReport.InnerText = aAccount.ShowReport();
        }
    }
}