using System.Linq.Expressions;
using System.Security.Principal;

namespace AccountLibrary
{
    public class AccountManager
    {
        public static List<Account> accountlist = new List<Account>();
        public static void CallMainMenu()
        {
            Console.WriteLine("Select any one option");
            Console.WriteLine("1.Create new Account");
            Console.WriteLine("2.Work with existing Account");
            Console.WriteLine("3.Exit");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    CreateAccount();
                    break;
                case 2:
                    CallSubMenu();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;



            }
            SerialDeserial.SerializeData(accountlist);
        }
        public static void CreateAccount()
        {
            Console.WriteLine("Enter ID");
            double userId = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string userName = Console.ReadLine();

            Console.WriteLine("Balance");
            double userBalance = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter BankName:");
            string userbankName = Console.ReadLine();
            Account newaccount = new Account(userId, userName, userBalance, userbankName);
            accountlist.Add(newaccount);
        }

        public static void CallSubMenu()
        {
            Console.WriteLine("Which accound ID you want to acess");
            int userinput = int.Parse(Console.ReadLine());
            Account selectedaccount = null;
            foreach (Account account in accountlist)
            {

                if (account.Id == userinput)
                {
                    selectedaccount = account;
                    Account.PrintDetails(selectedaccount);
                    break;

                }


            }
            Console.WriteLine("Enter the operation you want to perform");
            Console.WriteLine("1.Deposit");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("3.Update");
            Console.WriteLine("4.Exit");
            int uservalue = int.Parse(Console.ReadLine());
            switch (uservalue)
            {
                case 1:
          
                        Console.WriteLine("Enter the amount you want to deposit");
                        double depositamt = double.Parse(Console.ReadLine());
                        Console.WriteLine("Account Balance is " + selectedaccount.Deposit(depositamt));
                        

                        break;
                case 2:
                         Console.WriteLine("Enter the amount you want to withdraw");
                         double amt = double.Parse(Console.ReadLine());
                        Console.WriteLine("Account balance is " + selectedaccount.Withdraw(amt));
                            break;
                        case 3:
                            UpdateUser();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;

                        }
            



                    }

            public static void UpdateUser()
        {
            Console.WriteLine("Enter the account ID");
            int userid = int.Parse(Console.ReadLine());

            Account selectAccount = null;
            foreach (Account account in accountlist)
            {
                if (account.Id == userid)
                {

                    selectAccount = account;
                    break;


                }
                Console.WriteLine("Enter Account Name:");
                selectAccount.Name = Console.ReadLine();
                Console.WriteLine("Enter Bank Name:");
                selectAccount.BankName = Console.ReadLine();
                Console.WriteLine("Enter Initial Balance:");
                selectAccount.Balance = double.Parse(Console.ReadLine());

            }
        }
    }

}

