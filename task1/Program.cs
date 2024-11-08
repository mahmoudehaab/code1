using System.Threading.Channels;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallCarpet = 25;
            int largeCarpet = 35;

            Console.Write("Enter number of small carpets : ");
            int num1=int.Parse(Console.ReadLine());
            Console.Write("Enter number of large carpets : ");
            int num2 = int.Parse(Console.ReadLine());

            int cost = (num1 * smallCarpet) + (num2 * largeCarpet);
            double tax = cost * 0.06;
            double total = cost + tax;

            Console.WriteLine("Price per small carpets : " + smallCarpet);
            Console.WriteLine("Price per large carpets : " + largeCarpet);
            Console.WriteLine($"cost : {cost} ");
            Console.WriteLine($"tax : {tax} ");
            Console.WriteLine("===============================");
            Console.WriteLine($"total estimate : {total}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
