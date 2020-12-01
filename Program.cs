using System;

namespace Product_Registration_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int counter = 0;
            string answer;
            string[] names = new string [2];                        
            float[] prices = new float [2];
            bool [] sales = new bool [2] ;

            Console.WriteLine("-------------------------");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Welcome to our Product Registration System");
            Console.ResetColor();
            Console.WriteLine("-------------------------");

            do
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Menu");
                Console.WriteLine();
                Console.WriteLine();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[1] Register product");
                Console.WriteLine();
                Console.WriteLine("[2] List registered products");
                Console.WriteLine();
                Console.WriteLine("[3] Exit menu");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please choose one of the following options:\n");
                Console.WriteLine();
                choice = int.Parse(Console.ReadLine());
                Console.ResetColor();

            switch (choice)
                {   
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine();
                        Console.WriteLine("Product Registration");
                        Console.WriteLine();
                        do
                        {
                            if(counter < 2 ){
                            Console.WriteLine($"Please type the name of product {counter+1}:\n");
                            names[counter] = Console.ReadLine();
                            Console.WriteLine();
                            
                            Console.WriteLine();
                            Console.Write($"Please type price of product {counter+1}: $ ");
                            prices[counter] = float.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine($"Is product {names[counter]} on sale? [true] / [false] ");
                            Console.WriteLine();
                            sales[counter] = bool.Parse(Console.ReadLine());
                            Console.WriteLine();

                            counter++;

                            }
                            
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Product Registration Limit Exceeded");
                                Console.WriteLine();
                                break;
                            }
                            
                            Console.WriteLine();
                            Console.WriteLine("Would you like to register another product? [yes = y]  [no = n]\n");
                            Console.WriteLine();
                            answer = Console.ReadLine().ToUpper();
                            Console.ResetColor();
                        
                        }  while (answer == "Y");

                        break;

                    case 2:
                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("List of registered products:");
                        Console.WriteLine();
                        
                        for (var i = 0; i < counter; i++)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"product: {names[i]}");
                            Console.WriteLine();
                            Console.WriteLine($"price:$ {prices[i].ToString("N2")}");
                            Console.WriteLine();
                            Console.WriteLine($"On Sale? :{sales[i]}");
                        }
                        Console.ResetColor();
                        break;
                    
                    case 3:
                        
                        Console.WriteLine();
                        Console.WriteLine("Thank you for using our System");
                        break;
                    
                    default:
                        
                        Console.Clear();
                        break;
                

            } 
   
            } while (choice != 3);
        }
    }
}