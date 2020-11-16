using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class BankAccount
    {
        private string AcctName;
        private decimal balance;
        public event EventHandler OverDrawn;
        public static decimal InterestRate
        {
            get
            {
                return 0.001m;
            }
        }
        public string AccountName
        {
            get
            {
                return AcctName;
            }
            set
            {
                AcctName = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
        }

        public void Deposit(decimal money)
        {
            balance = balance + money;
        }
        public void Withdraw(decimal money)
        {
            if (money <= balance)
                balance = balance - money;
            else
                OverDrawn(this, EventArgs.Empty);
        }
        public string Statement()
        {
            return "Account: " + AcctName + "\nBalance:£" + string.Format("{0:0.00}", balance);
        }
        public BankAccount(string name)
        {
            AcctName = name;
        }
        public BankAccount(string name, string address)
        {
            AcctName = "Visual Studio";
        }
        public BankAccount()
        {
            AcctName = "Temp Account";
        }

        public string GetAccount()
        {
            return AcctName;
        }
    }


}
namespace MyClass
{
    class BankAccount
    {

    }
}
