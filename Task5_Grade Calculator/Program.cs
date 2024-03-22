using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
   

    void DisplayInfo()
    {

        Console.WriteLine("Please enter the marks that you have achieved in the exam to determine your grades: ");
        Console.WriteLine("Maths: ");
        int T1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Chemistry: ");
        int T2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Physics: ");
        int T3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Computer Science: ");
        int T4 = Convert.ToInt32(Console.ReadLine());

        int sum = (T1, T2, T3, T4);

        int total;
        total = T1 + T2 + T3 + T4;
    }

    void Average()
    {

            Console.ReadLine();

            if (num1 >= 80)
            {
                Console.WriteLine($" Excellent! your grade is A ");
            }

            else if (num1 >= 70 && num1 <= 79)
            {
                Console.WriteLine($" Good! Your grade is B ");
            }

            else if (num1 >= 60 && num1 <= 69)
            {
                Console.WriteLine($" Satisfactory. Your grade is C ");
            }

            else if (num1 >= 50 && num1 <= 59)
            {
                Console.WriteLine($" Pass. Your grade is D ");
            }

            else if (num1 <= 50)
            {
                Console.WriteLine($" Fail. Your grade is F ");
            }
     
    }
    static void Main(string[] args )
        {
        

        }
}