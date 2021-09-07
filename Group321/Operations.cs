using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Operations
    {
        public static void ShowBalance(Account account)
        {
            System.Console.WriteLine($"YOUR BALANCE: {account.Ballance}");
        }

        public static void Transaction(Account accountSeller, Account accountGetter, double summ)
        {
            accountSeller.Ballance -= summ;
            accountGetter.Ballance += summ;
            System.Console.WriteLine("TRANSACTION COMPLETED");
            Console.WriteLine($"FIRST ACCOUNT : {accountSeller.Ballance} SECOND ACCOUNT: {accountGetter.Ballance}");
        }

        public static void Widtraw(Account accountSeller, double summ)
        {
            if (accountSeller.Ballance >= summ)
            {
                accountSeller.Ballance -= summ;
                System.Console.WriteLine("TRANSACTION COMPLETED");
                Console.WriteLine($"YOUR ACCOUNT HAS BEEN CHARGED: {summ} YOUR BALANCE: {accountSeller.Ballance}");
            }
            else
            {
                Console.WriteLine("THIS OPERATION IS IMPOSSIBLE!");
            }


        }

        public static void Deposit(Account acoountGetter, double summ)
        {

        }



    }
}
