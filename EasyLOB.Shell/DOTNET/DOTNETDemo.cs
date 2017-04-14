using System;

namespace EasyLOB.Shell
{
    partial class Program
    {
        private static void DOTNETDemo()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine(".NET Demo\n");
                Console.WriteLine("<0> RETURN");
                Console.WriteLine("<1> Lambda Expressions Demo");
                Console.WriteLine("<2> Lambda Expressions Helper Demo");
                Console.WriteLine("<3> NLog Demo");
                Console.Write("\nChoose an option... ");

                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();

                switch (key.KeyChar) // <ENTER> = '\r'
                {
                    case ('0'):
                        exit = true;
                        break;

                    case ('1'):
                        DOTNETLambdaDemo<Entity>();
                        break;

                    case ('2'):
                        DOTNETLambdaHelperDemo<Entity>();
                        break;

                    case ('3'):
                        DOTNETNLogDemo();
                        break;
                }

                if (!exit)
                {
                    Console.Write("\nPress <KEY> to continue... ");
                    Console.ReadKey();
                }
            }
        }
    }
}