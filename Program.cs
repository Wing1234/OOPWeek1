using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int total = 4; 
            int decision = total; 
            int mint = 1; 
            int chocolate = 1; 
            int strawberry = 1;
            bool same = false;

    
            string IceCreamDispensor = ""; 

            do
            {
                Console.WriteLine("Which ice cream would you like?");
                Console.WriteLine("1.) Mint");
                Console.WriteLine("2.) Chocolate");
                Console.WriteLine("3.) Strawberry"); 

                IceCreamDispensor = Console.ReadLine();
                IceCreamDecision(strawberry, mint, chocolate, IceCreamDispensor, same);
            }
            while(IceCreamDecision(total)); 
        }

        
        private static void IceCreamDecision(int mint, int chocolate, int strawberry, string IceCreamDispensor, bool same)
       
        {
        int total = 4; 
            switch (IceCreamDispensor)
            {
                case "1": Console.WriteLine("You purchased mint ice cream");
                    if (mint == 1)
                    {
                        same = false; 
                        Console.WriteLine("Not everyone chose Mint, sorry your choice cannot be served");
                    }
                    if (mint == 2)
                    {
                        same = false;
                        Console.WriteLine("Not everyone chose Mint, sorry your choice cannot be served");
                    }
                    if (mint == 3)
                    {
                        same = false;
                        Console.WriteLine("Not everyone chose Mint, sorry your choice cannot be served");
                    }
                    if (mint == 4)
                    {
                        same = true;
                        Console.WriteLine("Purchased Mint Ice Cream at a quantity of " + mint);
                    }
                    mint++;

                break; 

                case "2": Console.WriteLine("You purchased chocolate ice cream");
                    if (chocolate == 1)
                    {
                        Console.WriteLine("Not everyone chose Mint, sorry your choice cannot be served");
                        same = false; 
                    }
                    if (chocolate == 2)
                    {
                        Console.WriteLine("Not everyone chose Mint, sorry your choice cannot be served");
                        same = false; 
                    }
                    if (chocolate == 3)
                    {
                        Console.WriteLine("Not everyone chose Mint, sorry your choice cannot be served");
                        same = false;
                    }
                    if (chocolate == 4)
                    {
                        Console.WriteLine("Purchased chocolate Ice Cream at a quantity of " + chocolate); 
                        same = true; 
                    }
                    chocolate++;
                    break; 

                
                case "3": Console.WriteLine("You purchased strawberry ice cream");
                    if (strawberry == 1)
                    {
                        Console.WriteLine("Not everyone chose Mint, sorry your choice cannot be served");
                        same = false; 
                    }
                    if (strawberry == 2)
                    {
                        Console.WriteLine("Not everyone chose Mint, sorry your choice cannot be served");
                        same = false; 
                    }
                    if (strawberry == 3)
                    {
                        Console.WriteLine("Not everyone chose Mint, sorry your choice cannot be served");
                        same = false; 
                    }
                    if (strawberry == 4)
                    {
                        Console.WriteLine("Purchased strawberry Ice Cream at a quantity of " + strawberry);
                        same = true;  
                    }
                    strawberry++;
                    break;
                    default:  
                    break; 
                    
                 }
                 return total; 
            }   
        }
    }

            
            



    
