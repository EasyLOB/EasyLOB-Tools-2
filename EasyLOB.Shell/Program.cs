using System;

namespace EasyLOB.Shell
{
    partial class Program
    {
        private static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("EasyLOB Shell\n");
                Console.WriteLine("<0> EXIT");
                Console.WriteLine("<1> .NET Demo");
                Console.WriteLine("<2> Library Demo");
                Console.Write("\nChoose an option... ");

                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();

                switch (key.KeyChar) // <ENTER> = '\r'
                {
                    case ('0'):
                        exit = true;
                        break;

                    case ('1'):
                        DOTNETDemo();
                        break;

                    case ('2'):
                        LibraryDemo();
                        break;
                }

                if (!exit)
                {
                    Console.Write("\nPress <KEY> to continue... ");
                    Console.ReadKey();
                }
            }
        }

        private static void WriteException(Exception exception)
        {
            Console.WriteLine(exception.Message);
            if (exception.InnerException != null)
            {
                Console.WriteLine(exception.InnerException.Message);
            }
        }

    }
}