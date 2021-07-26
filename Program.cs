using System;

namespace XS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your gender: ");
            string gender = Console.ReadLine();
            if (age < 16 && gender == "f")
            {
                Console.WriteLine("Miss");
            }
            else if (age >= 16 && gender == "f")
            {
                Console.WriteLine("Ms.");
            }
            else if (age < 16 && gender == "m")
            {
                Console.WriteLine("Master");
            }
            else
            {
                Console.WriteLine("Mr");      
            }
        }
    }
}
