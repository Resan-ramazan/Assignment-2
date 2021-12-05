using System;

namespace Assigmnet2
{
    class Program
    {
        enum Menustate { Newgame = 1, about = 2, Quit = 3 }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;

            string s1 = " ", s2 = " ", s3 = " ", s4 = " ", s5 = " ", s6 = " ", s7 = " ", s8 = " ", s9 = " ";
            string T = "X";
            string input;
            int inputNumber = 0;
            int Tnumber = 0;

            Menustate state;
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("=======================");
            Console.WriteLine();
            int i = 0;

            while (true)
            {
                Console.WriteLine("1) New Game");
                Console.WriteLine("2) About Author");
                Console.WriteLine("3) Exit Game");
                while (!Enum.TryParse<Menustate>(Console.ReadKey().KeyChar.ToString(), out state)) ;
                Console.Clear();

                //New Game
                if (state == Menustate.Newgame)
                {
                    s1 = " "; s2 = " "; s3 = " "; s4 = " "; s5 = " "; s6 = " "; s7 = " "; s8 = " "; s9 = " ";
                    T = "X";
                    i = 0;
                    Tnumber = 0;

                    while (i < 9)
                    {
                        Console.WriteLine($" {s1} | {s2} | {s3}");
                        Console.WriteLine("---+---+---");
                        Console.WriteLine($" {s4} | {s5} | {s6}");
                        Console.WriteLine("---+---+---");
                        Console.WriteLine($" {s7} | {s8} | {s9}");

                        if (s1 == s2 && s1 == s3 && s1 != " " || 
                            s4 == s5 && s4 == s6 && s4 != " " ||
                            s7 == s8 && s7 == s9 && s7 != " " ||
                            s1 == s4 && s1 == s7 && s1 != " " ||
                            s2 == s5 && s2 == s8 && s2 != " " ||
                            s3 == s6 && s3 == s9 && s3 != " " ||
                            s1 == s5 && s1 == s9 && s1 != " " ||
                            s3 == s5 && s3 == s7 && s3 != " ")

                        {
                            Console.WriteLine($"{T} has won the game **");
                            Console.WriteLine("Press enter to return menu ");
                            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                break;
                            }

                        }

                        if (Tnumber % 2 == 0) T = "X";
                        else T = "O";

                        while (Tnumber < 9)

                        {
                            Console.Write($"{T}'s move > ");
                            input = Console.ReadLine();
                            if (!int.TryParse(input, out inputNumber)) continue;
                            switch (inputNumber)
                            {
                                case 1:
                                    if (s1 != " ")
                                    {
                                        Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                        continue;
                                    }
                                    s1 = T;
                                    break;
                                case 2:
                                    if (s2 != " ")
                                    {
                                        Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                        continue;
                                    }
                                    s2 = T;
                                    break;
                                case 3:
                                    if (s3 != " ")
                                    {
                                        Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                        continue;
                                    }
                                    s3 = T;
                                    break;
                                case 4:
                                    if (s4 != " ")
                                    {
                                        Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                        continue;
                                    }
                                    s4 = T;
                                    break;
                                case 5:
                                    if (s5 != " ")
                                    {
                                        Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                        continue;
                                    }
                                    s5 = T;
                                    break;
                                case 6:
                                    if (s6 != " ")
                                    {
                                        Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                        continue;
                                    }
                                    s6 = T;
                                    break;
                                case 7:
                                    if (s7 != " ")
                                    {
                                        Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                        continue;
                                    }
                                    s7 = T;
                                    break;
                                case 8:
                                    if (s8 != " ")
                                    {
                                        Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                        continue;
                                    }
                                    s8 = T;
                                    break;
                                case 9:
                                    if (s9 != " ")
                                    {
                                        Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                        continue;
                                    }
                                    s9 = T;
                                    break;
                                default:
                                    Console.WriteLine("ILLEGAL MOVE! TRY AGAIN");
                                    continue;
                            }
                            i++;
                            Tnumber++;
                            break;
                        }
                    }
                }
                //About Author

                else if (state == Menustate.about)
                {
                    Console.WriteLine("Coded by Ramazan, 2021. All rights reserved.");
                    Console.WriteLine("Press enter to return menu ");
                    if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        continue;
                    }
                }
                //Exit Game
                else if (state == Menustate.Quit)
                {
                    Console.WriteLine("Are you sure you want to exit? Press Y to exit, any key to return to main menu");
                    if (Console.ReadKey(true).Key == ConsoleKey.Y)
                    {
                        return;
                    }
                }
            }
        }
    }
}
