using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons_Mini_Fight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            Random AttackGenerator = new Random();
            string Charmender = "Charmender"; string Squirtle = "Squirtle"; string Balbasaur = "Balbasaur";
            int ChoosenHealth = 0, EnemyHealth = 0;
            int ChoosenAttack = 0, EnemyAttack = 0;
            #endregion
            #region Choosing
            Console.WriteLine("Choose One:\tCharmender\tSquirtle\tBalbasaur");
            string ChooseOne = Console.ReadLine();
            Console.WriteLine($"Your Choose is: {ChooseOne}");
            Console.WriteLine();
            if (ChooseOne == Charmender)
            {
                Console.WriteLine("Choose Enemy:\tSquirtle\tBalbasaur");
                ChoosenHealth = 39;
            }
            else if (ChooseOne == Squirtle)
            {
                Console.WriteLine("Choose Enemy:\tCharmender\tBalbasaur");
                ChoosenHealth = 44;
            }
            else if(ChooseOne == Balbasaur)
            {
                Console.WriteLine("Choose Enemy:\tSquirtle\tCharmender");
                ChoosenHealth = 45;
            }
            string ChooseEnemy = Console.ReadLine();
            Console.WriteLine($"Your Enemy is: {ChooseEnemy}");
            #endregion
            #region Assign Health Stat
            if (ChooseOne == Charmender)
            {
                EnemyHealth = 39;
            }
            else if (ChooseOne == Squirtle)
            {
                EnemyHealth = 44;
            }
            else if (ChooseOne == Balbasaur)
            {
                EnemyHealth = 45;
            }           
            if (ChooseEnemy == Charmender)
            {
                EnemyHealth = 39;
            }
            else if (ChooseEnemy == Squirtle)
            {
                EnemyHealth = 44;
            }
            else if (ChooseEnemy == Balbasaur)
            {
                EnemyHealth = 45;
            }
            Console.WriteLine();
            #endregion
            #region Fight
            for (int i = 1; i <= 3; i++)
            {
                #region Assign Attack Stat
                if (ChooseOne == Charmender)
                {
                    ChoosenAttack = AttackGenerator.Next(22, 32);
                }
                else if (ChooseOne == Squirtle)
                {
                    ChoosenAttack = AttackGenerator.Next(18, 28);
                }
                else if (ChooseOne == Balbasaur)
                {
                    ChoosenAttack = AttackGenerator.Next(19, 29);
                }
                if (ChooseEnemy == Charmender)
                {
                    EnemyAttack = AttackGenerator.Next(22, 32);
                }
                else if (ChooseEnemy == Squirtle)
                {
                    EnemyAttack = AttackGenerator.Next(18, 28);
                }
                else if (ChooseEnemy == Balbasaur)
                {
                    EnemyAttack = AttackGenerator.Next(19, 29);
                }
                #endregion                                
                #region Result
                if (ChoosenHealth <= 0 && EnemyHealth <= 0)
                {
                    Console.WriteLine($"{ChooseOne}:0hp\n" +
                                        $"{ChooseEnemy}:0hp");
                    Console.WriteLine("Draw!!!");
                    break;
                }
                else if (EnemyHealth <= 0 && ChoosenHealth > 0)
                {
                    Console.WriteLine($"{ChooseOne} Win!!!");
                    Console.WriteLine($"{ChooseOne}{ChoosenHealth}hp\n" +
                        $"{ChooseEnemy}: 0hp");
                    break;
                }               
                else if (ChoosenHealth <= 0 && EnemyHealth > 0)
                {
                    Console.WriteLine($"{ChooseEnemy} Win!!!");
                    Console.WriteLine($"{ChooseEnemy}:0hp\n" +
                                        $"{ChooseEnemy}:0hp");
                    Console.WriteLine("Draw!!!");
                    break;
                }
                else
                {
                    Console.WriteLine($"{ChooseOne}:{ChoosenHealth}hp\n" +
                                        $"{ChooseEnemy}:{EnemyHealth}hp");
                }
                EnemyHealth -= ChoosenAttack;

                ChoosenHealth -= EnemyAttack;
                #endregion
                #region Momentary Ones
                Console.WriteLine();
                Console.WriteLine($"Round {i}");
                Console.WriteLine();
                Console.WriteLine($"{ChooseOne} Attacks {ChooseEnemy} and deals {ChoosenAttack} damage ");
                Console.WriteLine($"{ChooseEnemy} Attacks {ChooseOne} and deals {EnemyAttack} damage ");
                Console.WriteLine();
                #endregion
                #region Alternative Result
                if (i == 3)
                {
                    Console.WriteLine("Draw!!!");
                }
                #endregion
            }
            #endregion
        }
    }
}