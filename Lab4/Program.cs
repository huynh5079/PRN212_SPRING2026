using System;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\n=== LAB 4: DELEGATE, EVENT AND LINQ ===");
                Console.WriteLine("1. Delegate Demo");
                Console.WriteLine("2. Event Demo (Account)");
                Console.WriteLine("3. LINQ Demo");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunDelegateDemo();
                        break;
                    case "2":
                        RunEventDemo();
                        break;
                    case "3":
                        LinqDemo.Run();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void RunDelegateDemo()
        {
            Console.WriteLine("\n****Delegate Example****");
            MathOperations m = new MathOperations();
            // Instantiate delegate with add method
            SampleDelegate dlgt = m.Add;
            dlgt += m.Subtract;
            dlgt += m.Multiply;
            // dlgt += m.Divide; // Optional if we want to show divide
            
            // Invoke Multicast Delegate
            dlgt(10, 90);
        }

        static void RunEventDemo()
        {
            Console.WriteLine("\n----- Event Demo -----");
            Account myAccount = new Account(1000);
            
            // Register event handler
            myAccount.BalanceChanged += (newBalance) => 
            {
                Console.WriteLine($"New account balance: {newBalance}");
            };

            Console.WriteLine("Initial Balance: 1000");
            Console.Write("Enter deposit amount: ");
            if(double.TryParse(Console.ReadLine(), out double deposit))
            {
                 myAccount.Deposit(deposit);
            }

            Console.Write("Enter withdrawal amount: ");
            if(double.TryParse(Console.ReadLine(), out double withdraw))
            {
                 myAccount.Withdraw(withdraw);
            }
        }
    }
}
