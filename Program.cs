using System;
using System.Collections.Generic;

namespace diceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.Clear();
            Console.WriteLine(@"
            
 ____  _  ____  _____   _____ ____  _      _____
/  _ \/ \/   _\/  __/  /  __//  _ \/ \__/|/  __/
| | \|| ||  /  |  \    | |  _| / \|| |\/|||  \  
| |_/|| ||  \_ |  /_   | |_//| |-||| |  |||  /_ 
\____/\_/\____/\____\  \____\\_/ \|\_/  \|\____\
                                                

            ");
            int diceIndex1;
            int diceIndex2;
            List<int> number = new List<int>();
            int game = 3;
            for(int i=0; i<game; i++){
                Console.WriteLine("Game: " + i);{
            Random one = new Random();
            diceIndex1 = one.Next(6);
            Random second = new Random();
            diceIndex2 = second.Next(6);
            Console.WriteLine("Dice 1-->" + diceIndex1);
            Console.WriteLine("Dice 2-->" +diceIndex2);
            number.Add(diceIndex1);
             number.Add(diceIndex2);
             int sum = diceIndex1+diceIndex2;
             var result = diceIndex1 == diceIndex2?"Your Score is 0":"Your Score is: " + sum;
             Console.WriteLine(result);
            }
            }
            // var result = diceIndex1 ==

        }
    }
}
