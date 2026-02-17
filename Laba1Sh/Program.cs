namespace Laba1Sh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int rubles = n / 100;
            int kopeyks = n % 100;
            int r1 = rubles % 10;
            int k1 = kopeyks % 10;

            string rublesStr="";
            string kopeyksSrt="";

            if (r1 == 0 || r1 >= 5 || rubles>=10 && rubles<=15)
                rublesStr = "Рублей";
            else if (r1 == 1)
                rublesStr = "Рубль";
            else if (r1 > 1 && r1 < 5)
                rublesStr = "Рубля";

            if (k1 == 0 || k1 >= 5 || kopeyks >= 10 && kopeyks <= 15)
                kopeyksSrt = "Копеек";
            else if (k1 == 1)
                kopeyksSrt = "Копейка";
            else if (k1 > 1 && k1 < 5)
                kopeyksSrt = "Копейки";

            if (rubles == 0)
                Console.WriteLine($"{kopeyks} {kopeyksSrt}");
            else if (kopeyks == 0)
                Console.WriteLine($"{rubles} {rublesStr} ровно");
            else Console.WriteLine($"{rubles} {rublesStr} {kopeyks} {kopeyksSrt}");

        }
    }
}
