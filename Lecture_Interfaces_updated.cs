using System;

namespace Interfaces
{
    public interface AccountOperations  //What
    {
        // interface  members // bluepring
        void showAccountDetails(); //What  should be done method definition
        double getDepositedAmount();
        void showBankAccount();
        void showBankAccountType();


    }

    public class Account : AccountOperations   // the Account class  inherits from the AccountOperations interface
    {
        private string account_type;
        private string name;
        private string bank_name;
        private string account_number;
        private double deposited_amount;
        
        public Account()
        {
            account_type = " ";
            name = " ";
            bank_name = "";
            account_number = "";
            deposited_amount = 0.0;
        }
        public Account(string t, string n, string b_n, string acn, double d_a)
        {
            account_type = t;
            name = n;
            bank_name = b_n;
            account_number = acn;
            deposited_amount = d_a;
        }


        public double getDepositedAmount() // Was defined in the Interface and implemented here.
        {
            double withhold_per = 0.23;
            return deposited_amount - (deposited_amount * withhold_per);
        }
        public void showAccountDetails() // How it should be done
        {
            Console.WriteLine("Bank: {0}", bank_name); // Console.WriteLine("Bank: "+ bank_name);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Account type: {0}", account_type);
            Console.WriteLine("Account Number: {0}", account_number);
            
            Console.WriteLine("Deposited Amount: {0}", deposited_amount);
            Console.WriteLine("Deposited Amount: {0}", getDepositedAmount());

        }

        public void showBankAccount()
        {
            Console.WriteLine("Account Number: {0}", account_number);
        }

        public void showBankAccountType()
        {
            Console.WriteLine("Account type: {0}", account_type);
        }


    }
    class DriverCode
    {

        static void Main(string[] args)
        {
            Account acc_1 = new Account("Cheque", "John", "Standard Bank","62482225000", 10.0);

            //acc_1.showAccountDetails();
            acc_1.showBankAccount();
            acc_1.showBankAccountType();

        }
    }
}
