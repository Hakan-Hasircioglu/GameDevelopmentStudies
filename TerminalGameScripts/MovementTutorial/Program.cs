using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MovementTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int charPosX = 5;
            int charPosY = 3;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"X:{charPosX}\nY:{charPosY}");
                for (int y = 1; y <= 5; y++)
                {
                    for (int x = 1; x <= 10; x++)
                    {
                        if (x == charPosX && y == charPosY)
                            Console.Write("O");
                        else
                            Console.Write("_");   
                    }
                    Console.WriteLine();
                }
                char Controll = Console.ReadKey().KeyChar;
                switch (Controll)
                {
                    case 'a':
                        charPosX--;
                        break;
                    case 'd':
                        charPosX++;
                        break;
                    case 'w':
                        charPosY--;
                        break;
                    case 's':
                        charPosY++;
                        break;
                }
                if (charPosY < 1)
                {
                    charPosY = 1;
                }
                else if (charPosY > 5)
                {
                    charPosY = 5;
                }
                if (charPosX < 1)
                {
                    charPosX = 1;
                }
                else if (charPosX > 10)
                {
                    charPosX = 10;
                }
            }
        }
    }
}