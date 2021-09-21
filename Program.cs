using System;
using System.Media;






namespace Geheimzahl_Samuel_Matarese
{
    class Program
    {
        static void Main(string[] args)
        {

            SoundPlayer player = new SoundPlayer("music.wav");
            player.Load();
            player.PlayLooping();


            string usereingabe = "_";
            Console.ForegroundColor
            = ConsoleColor.DarkCyan;
            Console.WriteLine("Herzlich Wilkommen zum Randomnumbergenerator.");
            Console.WriteLine("Bitte machen sie Ihren Sound an");
        Repeat:
            Console.ForegroundColor
           = ConsoleColor.DarkCyan;
            Console.WriteLine("Ihre Zahl wird generiert...");
            Random rd = new Random();
            int geheimzahl = rd.Next(0, 100);
            Console.WriteLine("Ihre Zahl wurde generiert. Sie können jetzt eine Zahl zwischen 1 und 100 raten:");
            Console.ForegroundColor
            = ConsoleColor.White;
            usereingabe = Console.ReadLine();
            int userzahl = 0;
            int versuche = 0;
            while (userzahl != geheimzahl)
            {

                versuche++;
                if (!int.TryParse(usereingabe, out userzahl))



                {
                    Console.ForegroundColor
                    = ConsoleColor.DarkRed;
                    Console.WriteLine("Bitte benutzen sie  eine Zahl:");
                    Console.ForegroundColor
                    = ConsoleColor.White;
                    usereingabe = Console.ReadLine();

                }
                else
                {
                    if (userzahl == 420)
                    {
                        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                        Console.WriteLine("░░░░░░░░░░▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄░░░░░░░░░");
                        Console.WriteLine("░░░░░░░░▄▀░░░░░░░░░░░░▄░░░░░░░▀▄░░░░░░░");
                        Console.WriteLine("░░░░░░░░█░░▄░░░░▄░░░░░░░░░░░░░░█░░░░░░░");
                        Console.WriteLine("░░░░░░░░█░░░░░░░░░░░░▄█▄▄░░▄░░░█░▄▄▄░░░");
                        Console.WriteLine("░▄▄▄▄▄░░█░░░░░░▀░░░░▀█░░▀▄░░░░░█▀▀░██░░");
                        Console.WriteLine("░██▄▀██▄█░░░▄░░░░░░░██░░░░▀▀▀▀▀░░░░██░░");
                        Console.WriteLine("░░▀██▄▀██░░░░░░░░▀░██▀░░░░░░░░░░░░░▀██░");
                        Console.WriteLine("░░░░▀████░▀░░░░▄░░░██░░░▄█░░░░▄░▄█░░██░");
                        Console.WriteLine("░░░░░░░▀█░░░░▄░░░░░██░░░░▄░░░▄░░▄░░░██░");
                        Console.WriteLine("░░░░░░░▄█▄░░░░░░░░░░░▀▄░░▀▀▀▀▀▀▀▀░░▄▀░░");
                        Console.WriteLine("░░░░░░█▀▀█████████▀▀▀▀████████████▀░░░░");
                        Console.WriteLine("░░░░░░████▀░░███▀░░░░░░▀███░░▀██▀░░░░░░");
                        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");




                        Console.ForegroundColor
                        = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Sie haben das Easteregg gefunden!!!");
                        Console.ForegroundColor
                        = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Wählen sie eine Zahl zwischen 1 und 100:");
                        Console.ForegroundColor
                       = ConsoleColor.White;
                        usereingabe = Console.ReadLine();
                    }
                    else

                    {

                        if (userzahl != geheimzahl)
                        {



                            if (userzahl >= 1 && userzahl <= 100)



                            {

                                if (userzahl < geheimzahl)
                                {
                                    Console.ForegroundColor
                                    = ConsoleColor.Green;
                                    Console.WriteLine("Die Geheimzahl ist grösser. Probieren sie es erneut.");
                                    Console.ForegroundColor
                                    = ConsoleColor.White;
                                    usereingabe = Console.ReadLine();


                                }
                                else
                                {
                                    Console.ForegroundColor
                                    = ConsoleColor.Green;
                                    Console.WriteLine("Die Geheimzahl ist kleiner. Probieren sie es erneut.");
                                    Console.ForegroundColor
                                    = ConsoleColor.White;
                                    usereingabe = Console.ReadLine();

                                }




                            }
                            else
                            {
                                Console.ForegroundColor
                                = ConsoleColor.DarkRed;
                                Console.WriteLine("Bitte benutzen sie eine Zahl zwischen 1 und 100:");
                                Console.ForegroundColor
                                = ConsoleColor.White;
                                usereingabe = Console.ReadLine();


                            }



                        }
                    }
                }
            }
            Console.ForegroundColor
            = ConsoleColor.Yellow;
            Console.WriteLine("Bravo sie haben die richtige Zahl erraten. Sie haben insgesamt " + versuche + " Versuche gebraucht.");
            Console.ForegroundColor
            = ConsoleColor.DarkCyan;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Wollen sie nochmal spielen? [ja|nein]");
            Console.ForegroundColor
            = ConsoleColor.White;
        Again:
            string userAntwort = Console.ReadLine().ToLower();
            switch (userAntwort)
            {
                case "ja":
                    Console.WriteLine();
                    goto Repeat;


                case "nein":
                    Console.ForegroundColor
                    = ConsoleColor.DarkCyan;
                    Console.WriteLine("Vielen Dank fürs spielen. :)");
                    break;

                default:
                    Console.ForegroundColor
                    = ConsoleColor.DarkCyan;
                    Console.WriteLine("Ungültige Eingabe Schreiben sie [ja|nein].");
                    goto Again;



            }




        }


    }

}
