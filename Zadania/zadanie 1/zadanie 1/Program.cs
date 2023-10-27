using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace lol
{
    class program
    {
        static void Main()
        {
            int nor = 0;
            char nar = 'a';
            string text = File.ReadAllText("C:\\Users\\Praktyka\\Desktop\\test\\test_tomasz_lyzwa.txt");
            char[] listaliter = text.ToCharArray();
            for (int i = 0; i < listaliter.Length; i++)
            {
                char c = listaliter[i];
                if (c == nar)
                {
                    nor++;
                }
            }
            Console.WriteLine(nor);
        }

    }
}