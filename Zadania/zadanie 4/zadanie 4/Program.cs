using System.IO;

namespace lol
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Podaj pln");
            string pln = Console.ReadLine();
            double kurs = 0.23;
            double usd = Convert.ToInt32(pln) * kurs;
            Console.WriteLine(usd);
        }

    }
}