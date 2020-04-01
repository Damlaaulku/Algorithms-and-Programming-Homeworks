using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{
    class Program
    {
        static void Main(string[] args)
        {

            string sayı, number, slot;
         
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("       |------GOOD  LUCK!------|  ");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("       |-----------------------|  ");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("       |||||||   |   |   |||||||  ");
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("       |||||||   |   |   |||||||  ");
            Console.SetCursorPosition(5, 9);
            Console.WriteLine("       |||||||   |   |   |||||||  ");
            Console.SetCursorPosition(5, 10);
            Console.WriteLine("       |-----------------------|  ");
            Console.SetCursorPosition(5, 11);
            Console.WriteLine("       |-----------------------|  ");

            Console.SetCursorPosition(50, 5);
            Console.Write("Please enter first letter:");
            sayı = Console.ReadLine();
            
            Console.SetCursorPosition(50, 7);
            Console.Write("Please enter second letter:");
            number = Console.ReadLine();
           

            Console.SetCursorPosition(50, 9);
            Console.Write("Please enter last letter:");
            slot = Console.ReadLine();
            
            Console.SetCursorPosition(20, 8);
            Console.WriteLine(sayı);
            Console.SetCursorPosition(24, 8);
            Console.WriteLine(number);
            Console.SetCursorPosition(28, 8);
            Console.WriteLine(slot);


            if (sayı == "X" || sayı == "x" || sayı == "Y" || sayı == "y" || sayı == "Z" || sayı == "z" || sayı == "J" && number == "X" || number == "x" || number == "Y" || number == "y" || number == "Z" || number == "z" || number == "J" && slot == "x" || slot == "Y" || slot == "y" || slot == "Z" || slot == "z" || slot == "J")
            { 
                if (sayı == "X" && number == "X" && slot == "X" || sayı == "Y" && number == "Y" && slot == "Y" || sayı == "Z" && number == "Z" && slot == "Z")
                {
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("CONGRATS!! You won $30 :)");
                }
                else if (sayı == "x" && number == "x" && slot == "x" || sayı == "y" && number == "y" && slot == "y" || sayı == "z" && number == "z" && slot == "z")
                {
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("CONGRATS!! You won $28 :)");
                }
                else if (sayı == "X" && number == "x" && slot == "x" || sayı == "x" && number == "X" && slot == "x" || sayı == "x" && number == "x" && slot == "X" || sayı == "Y" && number == "y" && slot == "y" || sayı == "y" && number == "Y" && slot == "y" || sayı == "y" && number == "y" && slot == "Y" || sayı == "Z" && number == "z" && slot == "z" || sayı == "z" && number == "Z" && slot == "z" || sayı == "z" && number == "z" && slot == "Z" || sayı == "z" && number == "Z" && slot == "Z" || sayı == "Z" && number == "z" && slot == "Z" || sayı == "Z" && number == "Z" && slot == "z" || sayı == "x" && number == "X" && slot == "X" || sayı == "X" && number == "x" && slot == "X" || sayı == "x" && number == "x" && slot == "X" || sayı == "y" && number == "Y" && slot == "Y" || sayı == "Y" && number == "y" && slot == "Y" || sayı == "Y" && number == "Y" && slot == "y")
                {
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("CONGRATS!! You won $26 :)");
                }
                else if (sayı == "X" && number == "Y" && slot == "Z" || sayı == "X" && number == "Z" && slot == "Y" || sayı == "Y" && number == "X" && slot == "Z" || sayı == "Y" && number == "Z" && slot == "X" || sayı == "Z" && number == "X" && slot == "Y" || sayı == "Z" && number == "Y" && slot == "X")
                {
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("CONGRATS!! You won $24 :)");
                }
                else if (sayı == "x" && number == "y" && slot == "z" || sayı == "x" && number == "z" && slot == "y" || sayı == "y" && number == "x" && slot == "z" || sayı == "y" && number == "z" && slot == "x" || sayı == "z" && number == "x" && slot == "y" || sayı == "z" && number == "y" && slot == "x")
                {
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("CONGRATS!! You won $22 :)");
                }
                else if (sayı == "x" && number == "Y" && slot == "Z" || sayı == "x" && number == "Y" && slot == "z" || sayı == "x" && number == "y" && slot == "Z" || sayı == "X" && number == "Y" && slot == "z" || sayı == "X" && number == "y" && slot == "Z" || sayı == "X" && number == "y" && slot == "z" || sayı == "y" && number == "X" && slot == "Z" || sayı == "y" && number == "X" && slot == "z" || sayı == "y" && number == "x" && slot == "Z" || sayı == "Y" && number == "X" && slot == "z" || sayı == "Y" && number == "x" && slot == "Z" || sayı == "Y" && number == "x" && slot == "z" || sayı == "z" && number == "X" && slot == "Y" || sayı == "z" && number == "X" && slot == "y" || sayı == "z" && number == "x" && slot == "Y" || sayı == "Z" && number == "X" && slot == "y" || sayı == "Z" && number == "x" && slot == "Y" || sayı == "Z" && number == "x" && slot == "y" || sayı == "x" && number == "Z" && slot == "Y" || sayı == "x" && number == "z" && slot == "Y" || sayı == "x" && number == "Z" && slot == "y" || sayı == "X" && number == "z" && slot == "Y" || sayı == "X" && number == "Z" && slot == "y" || sayı == "X" && number == "z" && slot == "y" || sayı == "y" && number == "Z" && slot == "X" || sayı == "y" && number == "z" && slot == "X" || sayı == "y" && number == "Z" && slot == "x" || sayı == "Y" && number == "z" && slot == "X" || sayı == "Y" && number == "Z" && slot == "x" || sayı == "Y" && number == "z" && slot == "x" || sayı == "z" && number == "Y" && slot == "X" || sayı == "z" && number == "Y" && slot == "x" || sayı == "z" && number == "y" && slot == "X" || sayı == "Z" && number == "y" && slot == "X" || sayı == "Z" && number == "Y" && slot == "x" || sayı == "Z" && number == "y" && slot == "x")
                {
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("CONGRATS!! You won $20 :)");
                }
                else if (sayı == "X" && number == "X" && slot == "Y" || sayı == "X" && number == "Y" && slot == "X" || sayı == "X" && number == "Z" && slot == "X" || sayı == "X" && number == "X" && slot == "Z" || sayı == "X" && number == "Y" && slot == "Y" || sayı == "X" && number == "Z" && slot == "Z" || sayı == "Y" && number == "Y" && slot == "X" || sayı == "Y" && number == "X" && slot == "Y" || sayı == "Y" && number == "Z" && slot == "Y" || sayı == "Y" && number == "Y" && slot == "Z" || sayı == "Y" && number == "X" && slot == "X" || sayı == "Y" && number == "Z" && slot == "Z" || sayı == "Z" && number == "Z" && slot == "X" || sayı == "Z" && number == "Z" && slot == "Y" || sayı == "Z" && number == "X" && slot == "Z" || sayı == "Z" && number == "Y" && slot == "Z" || sayı == "Z" && number == "Y" && slot == "Y" || sayı == "Z" && number == "X" && slot == "X")
                {
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("CONGRATS!! You won $18 :)");
                }
                else if (sayı == "x" && number == "x" && slot == "y" || sayı == "x" && number == "y" && slot == "x" || sayı == "x" && number == "x" && slot == "z" || sayı == "x" && number == "z" && slot == "x" || sayı == "x" && number == "z" && slot == "z" || sayı == "x" && number == "y" && slot == "y" || sayı == "y" && number == "y" && slot == "z" || sayı == "y" && number == "y" && slot == "x" || sayı == "y" && number == "x" && slot == "y" || sayı == "y" && number == "z" && slot == "y" || sayı == "y" && number == "z" && slot == "z" || sayı == "y" && number == "x" && slot == "x" || sayı == "z" && number == "z" && slot == "x" || sayı == "z" && number == "z" && slot == "y" || sayı == "z" && number == "x" && slot == "z" || sayı == "z" && number == "y" && slot == "z" || sayı == "z" && number == "y" && slot == "y" || sayı == "z" && number == "x" && slot == "x")
                {
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("CONGRATS!! You won $16 :)");
                }
                else if (sayı == "J" && number == "X" && slot == "X" || sayı == "J" && number == "Y" && slot == "Y" || sayı == "J" && number == "Z" && slot == "Z" || sayı == "X" && number == "J" && slot == "X" || sayı == "X" && number == "X" && slot == "J" || sayı == "Y" && number == "J" && slot == "Y" || sayı == "Y" && number == "Y" && slot == "J" || sayı == "Z" && number == "J" && slot == "Z" || sayı == "Z" && number == "Z" && slot == "J" || sayı == "J" && number == "J" && slot == "X" || sayı == "J" && number == "X" && slot == "J" || sayı == "X" && number == "J" && slot == "J" || sayı == "J" && number == "J" && slot == "Y" || sayı == "J" && number == "Y" && slot == "J" || sayı == "Y" && number == "Y" && slot == "J" || sayı == "J" && number == "J" && slot == "Z" || sayı == "J" && number == "Z" && slot == "J" || sayı == "Z" && number == "J" && slot == "J" || sayı == "J" && number == "J" && slot == "J")
                {
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("LUCKY YOU!! You won $30 :)");
                }
                else if (sayı == "J" && number == "x" && slot == "x" || sayı == "J" && number == "y" && slot == "y" || sayı == "J" && number == "z" && slot == "z" || sayı == "x" && number == "J" && slot == "x" || sayı == "x" && number == "x" && slot == "J" || sayı == "y" && number == "J" && slot == "y" || sayı == "y" && number == "y" && slot == "J" || sayı == "z" && number == "J" && slot == "z" || sayı == "z" && number == "z" && slot == "J" || sayı == "J" && number == "J" && slot == "x" || sayı == "J" && number == "x" && slot == "J" || sayı == "x" && number == "J" && slot == "J" || sayı == "J" && number == "J" && slot == "y" || sayı == "J" && number == "y" && slot == "J" || sayı == "y" && number == "J" && slot == "J" || sayı == "J" && number == "J" && slot == "z" || sayı == "J" && number == "z" && slot == "J" || sayı == "z" && number == "J" && slot == "J")
                {
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("LUCKY YOU!! You won $28 :)");
                }
                else if (sayı == "X" && number == "x" && slot == "J" || sayı == "X" && number == "J" && slot == "x" || sayı == "J" && number == "X" && slot == "x" || sayı == "J" && number == "x" && slot == "X" || sayı == "x" && number == "J" && slot == "X" || sayı == "x" && number == "X" && slot == "J" || sayı == "Y" && number == "y" && slot == "J" || sayı == "Y" && number == "J" && slot == "y" || sayı == "J" && number == "Y" && slot == "y" || sayı == "J" && number == "y" && slot == "Y" || sayı == "y" && number == "J" && slot == "Y" || sayı == "y" && number == "Y" && slot == "J" || sayı == "Z" && number == "z" && slot == "J" || sayı == "Z" && number == "J" && slot == "z" || sayı == "J" && number == "Z" && slot == "z" || sayı == "J" && number == "z" && slot == "Z" || sayı == "z" && number == "J" && slot == "Z" || sayı == "z" && number == "Z" && slot == "J")
                {
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("LUCKY YOU!! You won $26 :)");
                }
                else if (sayı == "X" && number == "Y" && slot == "J" || sayı == "X" && number == "J" && slot == "Y" || sayı == "J" && number == "X" && slot == "Y" || sayı == "Y" && number == "X" && slot == "J" || sayı == "Y" && number == "J" && slot == "X" || sayı == "J" && number == "Y" && slot == "X" || sayı == "X" && number == "Z" && slot == "J" || sayı == "X" && number == "J" && slot == "Z" || sayı == "J" && number == "X" && slot == "Z" || sayı == "Z" && number == "X" && slot == "J" || sayı == "Z" && number == "J" && slot == "X" || sayı == "J" && number == "Z" && slot == "X" || sayı == "Z" && number == "Y" && slot == "J" || sayı == "Z" && number == "J" && slot == "Y" || sayı == "J" && number == "Z" && slot == "Y" || sayı == "Y" && number == "Z" && slot == "J" || sayı == "Y" && number == "J" && slot == "Z" || sayı == "J" && number == "Y" && slot == "Z")
                {
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("LUCKY YOU!! You won $24 :)");
                }
                else if (sayı == "x" && number == "y" && slot == "J" || sayı == "x" && number == "J" && slot == "y" || sayı == "J" && number == "x" && slot == "y" || sayı == "y" && number == "x" && slot == "J" || sayı == "y" && number == "J" && slot == "x" || sayı == "J" && number == "y" && slot == "x" || sayı == "x" && number == "z" && slot == "J" || sayı == "x" && number == "J" && slot == "z" || sayı == "J" && number == "x" && slot == "z" || sayı == "z" && number == "x" && slot == "J" || sayı == "z" && number == "J" && slot == "x" || sayı == "J" && number == "z" && slot == "x" || sayı == "z" && number == "y" && slot == "J" || sayı == "z" && number == "J" && slot == "y" || sayı == "J" && number == "z" && slot == "y" || sayı == "y" && number == "z" && slot == "J" || sayı == "y" && number == "J" && slot == "z" || sayı == "J" && number == "y" && slot == "z")
                {
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("LUCKY YOU!! You won $22 :)");
                }
                else if (sayı == "x" && number == "Y" && slot == "J" || sayı == "x" && number == "Z" && slot == "J" || sayı == "x" && number == "J" && slot == "Y" || sayı == "x" && number == "J" && slot == "Z" || sayı == "J" && number == "x" && slot == "Y" || sayı == "J" && number == "x" && slot == "Z" || sayı == "Y" && number == "x" && slot == "J" || sayı == "Z" && number == "x" && slot == "J" || sayı == "x" && number == "Y" && slot == "J" || sayı == "x" && number == "Z" && slot == "J" || sayı == "J" && number == "Z" && slot == "x" || sayı == "J" && number == "Y" && slot == "x" || sayı == "y" && number == "X" && slot == "J" || sayı == "y" && number == "Z" && slot == "J" || sayı == "y" && number == "J" && slot == "X" || sayı == "y" && number == "J" && slot == "Z" || sayı == "X" && number == "y" && slot == "J" || sayı == "Z" && number == "y" && slot == "J" || sayı == "X" && number == "J" && slot == "y" || sayı == "Z" && number == "J" && slot == "y" || sayı == "J" && number == "Z" && slot == "y" || sayı == "J" && number == "Z" && slot == "x" || sayı == "J" && number == "y" && slot == "Z" || sayı == "J" && number == "x" && slot == "Z" || sayı == "z" && number == "X" && slot == "J" || sayı == "z" && number == "Y" && slot == "J" || sayı == "z" && number == "J" && slot == "x" || sayı == "z" && number == "J" && slot == "Y" || sayı == "X" && number == "z" && slot == "J" || sayı == "Y" && number == "z" && slot == "J" || sayı == "X" && number == "J" && slot == "z" || sayı == "Y" && number == "J" && slot == "z" || sayı == "J" && number == "X" && slot == "z" || sayı == "J" && number == "Y" && slot == "z" || sayı == "J" && number == "z" && slot == "X" || sayı == "J" && number == "z" && slot == "Y")
                {
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("LUCKY YOU!! You won $20 :)");
                }
                else
                {
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("TRY AGAIN!");
                }
            }
                else 
                {
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("Please enter right letters!");
                }

            Console.ReadLine();

        }
    }
}
    

