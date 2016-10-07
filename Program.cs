using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {           
                int People = 4; 
                int Mint = 4; 
                int Chocolate = 4; 
                int Strawberry = 4; 
                bool allSold = false; 
                int iceCreamChoice = 0; 

                do
                {

                Console.WriteLine("Which ice cream would you like?");
                Console.WriteLine("1.) Mint: " + " In stock " + Mint);
                Console.WriteLine("2.) Chocolate: " + " In stock: " + Chocolate);
                Console.WriteLine("3.) Strawberry" + " In stock: " + Strawberry); 
                Console.WriteLine("4.) Order Complete"); 

                Console.ReadLine(); 
                } 
                while(allSold == false && People > 0);

                if(iceCreamChoice == 1)
                {
                    iceCreamChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You've purchased mint ice cream");
                    People--; 
                }
                else if (iceCreamChoice == 2)
                {
                    iceCreamChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You've purchased Chocolate ice cream");
                    People--; 
                }
                else if (iceCreamChoice == 3)
                {
                    iceCreamChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You've purchased Strawberry ice cream");
                    People--; 
                }

                 if(allSold == true)
                {
                    Console.WriteLine("Your purchase has been complete! Thank you."); 
                    Console.ReadLine(); 
                }
                Console.ReadLine();
            }   
        }
    }
            
            



    
