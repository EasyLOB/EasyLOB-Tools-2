using EasyLOB.Library.Mvc;
using System;

namespace EasyLOB.Shell
{
    partial class Program
    {
        private static void LibraryWebDemo()
        {
            Console.WriteLine("\nWeb Demo");
            Console.WriteLine("\nIs Web ? " + (MvcHelper.IsWeb ? "YES" : "NO"));
            Console.WriteLine("Session Write");
            SessionWrite();
            Console.WriteLine("Session Read");
            SessionRead();
            Console.WriteLine("Session Clear");
            SessionClear();
        }

        private static void SessionWrite()
        {
            Console.WriteLine("1 => Session[A]");
            SessionHelper.Write("A", "1");
            Console.WriteLine("2 => Session[B]");
            SessionHelper.Write("B", "2");
        }

        private static void SessionRead()
        {
            string sessionName;

            sessionName = "A";
            Console.WriteLine(((string)SessionHelper.Read(sessionName) ?? "") + " <= " + "Session[" + sessionName + "]");
            sessionName = "B";
            Console.WriteLine(((string)SessionHelper.Read(sessionName) ?? "") + " <= " + "Session[" + sessionName + "]");
        }

        private static void SessionClear()
        {
            string sessionName;

            sessionName = "A";
            SessionHelper.Clear(sessionName);
            Console.WriteLine((string)SessionHelper.Read(sessionName) ?? "" + " <= " + "Session[" + sessionName + "]");
            sessionName = "B";
            SessionHelper.Clear(sessionName);
            Console.WriteLine((string)SessionHelper.Read(sessionName) ?? "" + " <= " + "Session[" + sessionName + "]");
        }
    }
}