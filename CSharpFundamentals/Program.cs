using System;
namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            Book book = new("Emils GradeBook");

            
            while (true)
            {
                Console.Write("Enter grade: ");
                string input = Console.ReadLine();
                if (input == "q") break;
                book.AddGrade(Convert.ToDouble(input));
            }

            Statistics stats = book.GetStatistics();
            Console.WriteLine($"Average: {stats.Average:N1}");
            Console.WriteLine($"Low: {stats.Low:N1}");
            Console.WriteLine($"High: {stats.High:N1}");
            Console.WriteLine($"Letter grade: {stats.Letter}");

        }
    }
}
