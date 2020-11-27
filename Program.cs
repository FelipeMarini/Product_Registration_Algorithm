using System;

namespace Product_Registration_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            int choice = 0;
            
            

            string[] names = new string [10];
            float[] prices = new float [10]; 


        do {
        
        Console.WriteLine();    
        Console.WriteLine("Welcome to the Product Registration System");
        Console.WriteLine();

        Console.WriteLine("Main Menu")
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
        
        
        case 1: 

        if (counter < 10) {
            
            do
            {
                    Console.WriteLine();
                    Console.WriteLine($"Please type in Product {counter + 1} name:\n ");
                    names[counter] = Console.ReadLine();
                    Console.WriteLine();
                    
                    Console.WriteLine();
                    Console.WriteLine($"Please type in Product {counter + 1} price:\n$ ");
                    prices[counter] = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.WriteLine($"Is Product {names[counter]} on sale? /n")
            
                    counter ++;

                
            } while (counter < 10);
                
            
        } else {
                
                Console.WriteLine();
                Console.WriteLine("Limit for registering Products exceeded");
                Console.WriteLine();
               
               }

               break;



        case 2: 

                Console.WriteLine();
                Console.WriteLine("Here is the list of the Registered Products:");
                Console.WriteLine();
                Console.WriteLine();

                for (var i = 0; i < counter; i++)
                {
                    
                
                }
        
        }

    
    
    } while (choice != 3);
        
        
        
        
        }
    }
}
