using System;

namespace valami 

{

    class Program

    {

        static char[,] képernyő = new char[25, 80]; 

        static int kurzorX = 0, kurzorY = 0; 

        static ConsoleColor aktuálisSzín = ConsoleColor.White; 

        static string Karakter = "█"; 

        static ConsoleColor kurzorSzín = ConsoleColor.White; 

        static void nemtom() 

        {

            for (int y = 0; y < 25; y++)

            {

                for (int x = 0; x < 80; x++)

                {

                    képernyő[y, x] = ' ';

                }

            }

        }

        static void mozgas() 

        {

            for (int y = 0; y < 25; y++)

            {

                Console.SetCursorPosition(0, y);

                for (int x = 0; x < 80; x++)

                {

                    Console.ForegroundColor = aktuálisSzín;

                    Console.Write(képernyő[y, x]);

                }

            }

            Console.SetCursorPosition(kurzorX, kurzorY);

            Console.BackgroundColor = kurzorSzín;

            Console.Write(" ");

            Console.ResetColor();

            Console.SetCursorPosition(kurzorX, kurzorY);

            Console.CursorVisible = true;

        }

        static void SzínBeállítás(ConsoleColor szín) 
        {

            aktuálisSzín = szín;

            Console.ForegroundColor = szín;

        }

        static void Rajzol(string karakter) 

        {

            for (int i = 0; i < karakter.Length; i++)

            {

                képernyő[kurzorY, kurzorX + i] = karakter[i];

            }

        }

        static void KoordinátaMozgatás(int dx, int dy) 

        {

            int újX = kurzorX + dx, újY = kurzorY + dy; 

            if (újX >= 0 && újX < 80 && újY >= 0 && újY < 25)

            {

                kurzorX = újX;

                kurzorY = újY;

            }

        }

        static void Main(string[] args)

        {

            nemtom();

            while (true)

            {

                ConsoleKeyInfo billentyűInfo = Console.ReadKey();

                ConsoleKey billentyű = billentyűInfo.Key;

                switch (billentyű)

                {

                    case ConsoleKey.UpArrow:

                        KoordinátaMozgatás(0, -1);

                        break;

                    case ConsoleKey.DownArrow:

                        KoordinátaMozgatás(0, 1);

                        break;

                    case ConsoleKey.LeftArrow:

                        KoordinátaMozgatás(-1, 0);

                        break;

                    case ConsoleKey.RightArrow:

                        KoordinátaMozgatás(1, 0);

                        break;

                    case ConsoleKey.Spacebar:

                        Rajzol(Karakter);

                        break;

                    case ConsoleKey.D0:

                        SzínBeállítás(ConsoleColor.White);

                        break;

                    case ConsoleKey.D1:

                        SzínBeállítás(ConsoleColor.Magenta);

                        break;

                    case ConsoleKey.D2:

                        SzínBeállítás(ConsoleColor.Gray);

                        break;

                    case ConsoleKey.D3:

                        SzínBeállítás(ConsoleColor.Cyan);

                        break;

                    case ConsoleKey.D4:

                        SzínBeállítás(ConsoleColor.Green);

                        break;
                    case ConsoleKey.D5:


                        SzínBeállítás(ConsoleColor.Blue);

                        break;
                    case ConsoleKey.D6:

                        SzínBeállítás(ConsoleColor.Yellow);

                        break;
                    case ConsoleKey.D7:
                        SzínBeállítás(ConsoleColor.Red);

                        break;
                    case ConsoleKey.D8:
                        SzínBeállítás(ConsoleColor.DarkGreen);

                        break;
                    case ConsoleKey.D9:
                        SzínBeállítás(ConsoleColor.DarkYellow);

                        break;
                }
                mozgas();
            }

        }

    }
}







