using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar="0";
            while (svar!="kina")
            {
                Console.WriteLine("Vilket är världens folkrikaste land?");
                string svar1 = Console.ReadLine();
                svar = svar1.ToLower();
                if (svar != "kina")
                    Console.WriteLine("FEL");
                else
                    Console.WriteLine("RÄTT");

            }


        }
    }
}
