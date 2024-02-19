using System;
using System.Threading;

namespace TerminalGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                #region Variables
                // BOOL
                bool IsOk = true;
                int score = 1;
                // Player
                int positionX = -7;
                int positionY = -4;
                // Column Speed
                int columnSpeed = 1;
                // Column 1
                int columnPositionX = 4;
                int columnPositionY = 0;
                // Column 2
                int columnPositionX2 = 4;
                int columnPositionY2 = -1;
                // Column 3
                int columnPositionX3 = 4;
                int columnPositionY3 = -2;
                // Column 4
                int columnPositionX4 = 4;
                int columnPositionY4 = -3;
                // Column 5
                Random rng = new Random();
                int columnPositionX5 = 4;
                int columnPositionY5 = -4;
                // Joker Column
                int columnJokerX = 99;
                int columnJokerY = 99;
                // Reverse Joker
                int columnRevJokerX = 99;
                int columnRevJokerY = 99;
                // Check Game is Over
                bool dead = false;
                // Difficulty
                int diff = 0;
                #endregion
                while (true)
                {
                    while (!Console.KeyAvailable)
                    {
                        #region Difficulity
                        while (IsOk)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Difficulty:\nEasy = E\tNormal = N\tHard = H\tImpossible = I");
                            char difficulty = Console.ReadKey().KeyChar;
                            if (difficulty == 'E' || difficulty == 'e')
                            {
                                diff = 500;
                                IsOk = false;
                                break;
                            }
                            else if (difficulty == 'N' || difficulty == 'n')
                            {
                                diff = 350;
                                IsOk = false;
                                break;
                            }
                            else if (difficulty == 'H' || difficulty == 'h')
                            {
                                diff = 100;
                                IsOk = false;
                                break;
                            }
                            else if (difficulty == 'I' || difficulty == 'i')
                            {
                                diff = 20;
                                IsOk = false;
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Invalid input!");
                                Console.ForegroundColor = ConsoleColor.Green;
                                continue;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        #endregion

                        #region Column Spawnning And Positioning
                        if (score > 50)
                        {
                            if (score % 11 == 0)
                            {
                                columnRevJokerX = -9;
                                columnRevJokerY = -4;
                            }
                            else
                            {
                                columnRevJokerX = 99;
                                columnRevJokerY = 99;
                            }
                        }
                        if (score >= 30)
                        {
                            if (columnJokerX > 1)
                            {
                                columnJokerX = rng.Next(1, 5);
                                columnJokerY = rng.Next(-8, 1);
                            }
                            else if (columnJokerX < -9)
                            {
                                columnJokerX = rng.Next(1, 5);
                                columnJokerY = rng.Next(-8, 1);
                            }
                        }
                        if (columnRevJokerX > 1)
                        {
                            columnRevJokerX = -9;
                        }
                        else if (columnRevJokerX < -9)
                        {
                            columnRevJokerX = 1;
                        }
                        if (columnPositionX < -9 && columnPositionY == 0)
                        {
                            columnPositionX = rng.Next(2, 5);
                            columnPositionY = -8;
                        }
                        else if (columnPositionX < -9 && columnPositionY == -8)
                        {
                            columnPositionX = rng.Next(2, 5);
                            columnPositionY = 0;
                        }
                        if (columnPositionX2 < -9 && columnPositionY2 == -1)
                        {
                            columnPositionX2 = rng.Next(2, 5);
                            columnPositionY2 = -7;
                        }
                        else if (columnPositionX2 < -9 && columnPositionY2 == -7)
                        {
                            columnPositionX2 = rng.Next(2, 5);
                            columnPositionY2 = -1;
                        }
                        if (columnPositionX3 < -9 && columnPositionY3 == -2)
                        {
                            columnPositionX3 = rng.Next(2, 5);
                            columnPositionY3 = -6;
                        }
                        else if (columnPositionX3 < -9 && columnPositionY3 == -6)
                        {
                            columnPositionX3 = rng.Next(2, 5);
                            columnPositionY3 = -2;
                        }
                        if (columnPositionX4 < -9 && columnPositionY4 == -3)
                        {
                            columnPositionX4 = rng.Next(2, 5);
                            columnPositionY4 = -5;
                        }
                        else if (columnPositionX4 < -9 && columnPositionY4 == -5)
                        {
                            columnPositionX4 = rng.Next(2, 5);
                            columnPositionY4 = -3;
                        }
                        if (columnPositionX5 < -9)
                        {
                            columnPositionX5 = rng.Next(2, 5);
                        }
                        #endregion

                        #region In Game
                        Console.Clear();
                        Console.WriteLine($"Score:{score}");
                        score++;
                        for (int y = -9; y <= 1; y++)
                        {
                            for (int x = -9; x <= 5; x++)
                            {
                               if (positionY == y && positionX == x)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(">");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                else if (columnPositionY == y && columnPositionX == x)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("|");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    columnPositionX -= columnSpeed;
                                }
                                else if (columnPositionY2 == y && columnPositionX2 == x)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("|");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    columnPositionX2 -= columnSpeed;
                                }
                                else if (columnPositionY3 == y && columnPositionX3 == x)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("|");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    columnPositionX3 -= columnSpeed;
                                }
                                else if (columnPositionY4 == y && columnPositionX4 == x)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("|");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    columnPositionX4 -= columnSpeed;
                                }
                                else if (columnJokerY == y && columnJokerX == x)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("<");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    columnJokerX -= columnSpeed;
                                }
                                else if (columnRevJokerY == y && columnRevJokerX == x)
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.Write(">");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    columnRevJokerX += columnSpeed;
                                }
                                else if (columnPositionY5 == y && columnPositionX5 == x)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("|");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    columnPositionX5 -= columnSpeed;
                                }
                                // Draw Line
                                else if (y == -9 || y == 1)
                                {

                                    Console.Write("-");

                                }
                                else if (x == -9 || x == 5)
                                {

                                    Console.Write("|");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.WriteLine();
                        }
                        Thread.Sleep(diff);
                        #endregion

                        #region Check
                        if (positionY == columnPositionY && positionX == columnPositionX ||
                            positionY == columnPositionY2 && positionX == columnPositionX2 ||
                            positionY == columnPositionY3 && positionX == columnPositionX3 ||
                            positionY == columnPositionY4 && positionX == columnPositionX4 ||
                            positionY == columnPositionY5 && positionX == columnPositionX5 ||
                            positionY == columnJokerY && positionX == columnJokerX ||
                            positionY == columnRevJokerY && positionX == columnRevJokerX
                            )
                        {
                            dead = true;
                            break;
                        }
                        if (positionX <= -9 || positionX >= 5 || positionY <= -9 || positionY >= 1)
                        {
                            dead = true;
                            break;
                        }                       
                        #endregion

                    }
                    #region If Game Over
                    if (dead)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("\tG A M E   O V E R !!!");
                        break;
                    }
                    #endregion

                    #region Commands
                    ConsoleKeyInfo input_ = Console.ReadKey();

                    if (input_.KeyChar == 'A' || input_.KeyChar == 'a')
                    {
                        positionX--;
                    }
                    else if (input_.KeyChar == 'D' || input_.KeyChar == 'd')
                    {
                        positionX++;
                    }
                    else if (input_.KeyChar == 'W' || input_.KeyChar == 'w')
                    {
                        positionY--;
                    }
                    else if (input_.KeyChar == 'S' || input_.KeyChar == 's')
                    {
                        positionY++;
                    }

                    #endregion
                }
                #region Try Again?
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("Do you Want try Again? Y/N");
                    char again = Console.ReadKey().KeyChar;
                    if (again == 'Y' || again == 'y')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        IsOk = true;
                        break;
                    }
                    else if (again == 'N' || again == 'n')
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tG A M E   O V E R!");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Score:{score}");
                        Console.WriteLine();
                        return;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Invalid input");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                #endregion
            }
        }
    }
}
