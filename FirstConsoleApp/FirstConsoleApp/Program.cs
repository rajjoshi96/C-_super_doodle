using System;
using System.Text;

namespace FirstConsoleApp
{
    class Program
    {
        public static string title = "C# essential training";
        public static int whichpart;
        static void Main(string[] args)
        {
            whichpart = 2;
            string message = string.Format("Welcome to {0} Part {1}", title, whichpart);
            Console.WriteLine(message);

            Console.WriteLine("==================================================================");

            var mg = "  abcdeFGH   ";
            Console.WriteLine("Trim example: "+mg.Trim());
            string msg = "this was my message";
            Console.WriteLine("substring example: "+msg.Substring(5,12));
            string new_message = "  I am learning .NET C#  ";
            Console.WriteLine("Press Enter to continue");
            Console.WriteLine(new_message.Trim().Substring(1, new_message.Trim().Length-1).ToUpper());
            Console.WriteLine("==================================================================");

            Console.WriteLine("Stringbuilder example. Please refer String builder functions for more functions");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This is a string builder. ");
            sb.AppendLine("This is the string builder append line function. ");
            sb.Append("This is the string builder function of append. ");
            sb.Append("Another string builder append example.");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("==================================================================");
            Console.WriteLine("String formatiing example. Please refer String.format method for more functions");
            var city = "Perth";
            float temp = 33.2f;
            var dt = DateTime.Now;

            Console.WriteLine("City: {0}, Date: {1:D}, Temp: {2}", city, dt, temp);
            Console.WriteLine("==================================================================");
            var birthdate = new DateTime(1996, 01, 15);
            var Age = (DateTime.Now - birthdate) / 365;
            Console.WriteLine("Age: {0}",Age);
            Console.Read();
        }
    }
}

