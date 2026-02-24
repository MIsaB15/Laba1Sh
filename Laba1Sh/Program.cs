using System.Data;
using System.Net.NetworkInformation;

namespace Laba1Sh
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask.Run();
            

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = 0;
            for (int i = 0; i<y; i++)
            {
                z += x;
            }
            Console.WriteLine($"{x} * {y} = {z}");
           
            string line = Console.ReadLine();
            float spaces = 0;
            foreach (char c in line)
            {
                if (c == ' ')
                   spaces++; 
            }
            float spacesPercent = spaces / line.Length * 100;
            Console.WriteLine($"Символы помимо проблема составляют {100-spacesPercent} от всей длины строки");
        }
    }

    public class FirstTask
    {
        public static string RublesToString(int rubles)
        {
            int r1 = rubles % 10;
            string rStr;
            if (r1 == 0 || r1 >= 5 || rubles >= 10 && rubles <= 15)
                rStr = "Рублей";
            else if (r1 == 1)
                rStr = "Рубль";
            else if (r1 > 1 && r1 < 5)
                rStr = "Рубля";
            else
                rStr = "Рублей";
            return rStr;
        }

        public static string KopeyksToString(int kopeyks)
        {
            int k1 = kopeyks % 10;
            string kStr;
            if (k1 == 0 || k1 >= 5 || kopeyks >= 10 && kopeyks <= 15)
                kStr = "Копеек";
            else if (k1 == 1)
                kStr = "Копейка";
            else if (k1 > 1 && k1 < 5)
                kStr = "Копейки";
            else kStr = "Копеек";
            return kStr;
        }

        public static void PrintStr(int rubles, int kopeyks)
        {
            if (rubles == 0)
                Console.WriteLine($"{kopeyks} {FirstTask.KopeyksToString(kopeyks)}");
            else if (kopeyks == 0)
                Console.WriteLine($"{rubles} {FirstTask.RublesToString(rubles)} ровно");
            else Console.WriteLine($"{rubles} {FirstTask.RublesToString(rubles)} {kopeyks} {FirstTask.KopeyksToString(kopeyks)}");
        }
        
        public static void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int rubles = n / 100;
            int kopeyks = n % 100;
            FirstTask.PrintStr(rubles, kopeyks);
        }
    }
    public class SecondTask
    {

    }
    public class ThirdTask
    {

    }
}
