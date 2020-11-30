using System;

namespace Product_Registration_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            int choice = 0;
            string answer = "";
            

            string[] names = new string [3];
            float[] prices = new float [3];
            bool[] sales = new bool [3];
             


        do {
        
        Console.WriteLine();    
        Console.WriteLine("Welcome to the Product Registration System");
        Console.WriteLine();

        Console.WriteLine("Main Menu");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("[1] Product Registration");
        Console.WriteLine();
        Console.WriteLine("[2] List of Registered Products");
        Console.WriteLine();
        Console.WriteLine("[3] Exit Main Menu");
        Console.WriteLine();
        Console.Write("Choose your option: ");

        choice = int.Parse(Console.ReadLine());

        
         
        
        switch (choice) {
        
        
        case (1): 

        if (counter < 3) {
            
            do
            {
                    Console.WriteLine();
                    Console.WriteLine($"Please type in Product {counter + 1} name:\n ");
                    names[counter] = Console.ReadLine();
                    Console.WriteLine();
                    
                    Console.WriteLine();
                    Console.Write($"Please type in Product {counter + 1} price:  $ ");
                    prices[counter] = float.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine();

                    do {
                    
                    Console.WriteLine($"Is Product {names[counter]} on sale?  [yes = y] or [no = n] \n ");
                    answer = Console.ReadLine().ToLower();
                    
                    if (answer == "y")  {sales[counter] = true;}

                    else if (answer == "n") {sales[counter] = false;}

                    else if (answer != "y" && answer != "n") {

                        
                        Console.WriteLine();
                        Console.WriteLine("Invalid option");
                        Console.WriteLine();
                       }

                    
                    }   while (answer != "y" && answer != "n");

            
                    counter ++;

                
            } while (counter < 3);
                
            
        } else {
                
                Console.WriteLine();
                Console.WriteLine("Limit for registering Products exceeded");
                Console.WriteLine();
               
               }

               break;



        case (2): 

                Console.WriteLine();
                Console.WriteLine("Here is the list of the Registered Products:");
                Console.WriteLine();
                Console.WriteLine();

                for (var i = 0; i < names.Length; i++)
                {
                
                Console.WriteLine();    
        Console.WriteLine($"name: {names[i]}  |  price: ${prices[i].ToString("N2")}  |  on sale: {sales[i]}");
                
                }

                Console.WriteLine();

                break;

        case (3):

                Console.WriteLine();
                Console.WriteLine("Thanks for using our Product System");

                break;

        
        default: Console.Clear();
                 
                 break;
        
        }

    
    
    } while (choice != 3);
        
        
        
        
        }
    }
}
