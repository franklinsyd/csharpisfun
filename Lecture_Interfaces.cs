using System;

namespace Interfaces
{
    public interface AccountOperations
    {
        // interface  members // bluepring
        void showAccountDetails();
        //double getDepositedAmount();
        
    }
    public class Account : AccountOperations
    {
        private string account_type;
        private string name;
        private string bank_name;
        private double deposited_amount;
        
        public Account()
        {
            account_type = " ";
            name = " ";
            bank_name = "";
            deposited_amount = 0.0;
        }
        public Account(string t, string n, string b_n, double d_a)
        {
            account_type = t;
            name = n;
            bank_name = b_n;
            deposited_amount = d_a;
        }
     
        public void showAccountDetails()
        {
            Console.WriteLine("Bank: {0}", bank_name);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Account type: {0}", account_type);
        }
    }
    class DriverCode
    {

        static void Main(string[] args)
        {
            Account acc_1 = new Account("Cheque", "John", "Standard Bank", 10.0);

            acc_1.showAccountDetails();
        }
    }
}
