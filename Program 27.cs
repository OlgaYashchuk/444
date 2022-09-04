internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        //452 -> 11
        //82 -> 10
        //9012 -> 12
        double Res()
        {
            Console.WriteLine("Введите число ");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (x / 10 != 0)
            {
                sum = sum + x % 10;
                x = x / 10;
            }
            sum = sum + x;
            return sum;
        }
        Console.WriteLine(Res());
    }
}