using System.IO;
using System.Net.Http;

namespace TrueSaw01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //lab 01
            //ввести 3 числа, сумма, срок, процент

            int years = ReadInt("Введите год в котором деньги были положены в банк? ");
            int money = ReadInt("Какую сумму ");
            int percents = ReadInt("Под какой процент ");

            decimal money2 = money;
            for(int i = 1; i <= DateTime.Now.Year - years; i++)
            {
                money2 = money2 + money2 * percents / 100;
                Console.WriteLine($"{i} - {decimal.Round(money2, 5)}");
            }
        }

        static int ReadInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
    }
}