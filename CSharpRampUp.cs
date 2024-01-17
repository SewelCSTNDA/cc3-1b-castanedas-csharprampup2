using System;

public class RampUp2
{
    public static void Main()
    {
        Console.WriteLine ("Enter your weight in pounds: ");
        string weight = Console.ReadLine();
        
        try
        {
            double userweight = double.Parse(weight);
            double kilo = 0.453592;
            double result = userweight * kilo;
            Console.WriteLine($"Your weight in Kilograms is: {result}\n");
            Console.WriteLine("========================================\n");
        }
        
        catch
        {
            Console.WriteLine("Invalid Input");
        }
        
        Console.WriteLine ("Enter length in miles: ");
        string miles = Console.ReadLine();
        
        try
        {
            double usermiles = double.Parse(miles);
            double km = 1.60934;
            double kmResult = usermiles * km;
            Console.WriteLine($"{miles} miles in kilometres is: {kmResult}\n");
            Console.WriteLine("========================================\n");
        }
        
        catch
        {
            Console.WriteLine("Invalid Input");
        }
        
        Console.WriteLine ("Enter temperature in Fahrenheit: ");
        string fahren = Console.ReadLine();
        
        try
        {
            double userfahren = double.Parse(fahren);
            double celcius = -17.2222;
            double celciusResult = userfahren * celcius;
            Console.WriteLine($"{fahren} fahrenheit in celcius is: {celciusResult}\n");
            Console.WriteLine("========================================\n");
        }
        
        catch
        {
            Console.WriteLine("Invalid input");
        }
        
        Console.WriteLine("Enter an age for each student");
        
        Console.WriteLine ("Enter age for student 1: ");
        string age1 = Console.ReadLine();
        Console.WriteLine ("Enter age for student 2: ");
        string age2 = Console.ReadLine();
        Console.WriteLine ("Enter age for student 3: ");
        string age3 = Console.ReadLine();
        Console.WriteLine ("Enter age for student 4: ");
        string age4 = Console.ReadLine();
        Console.WriteLine ("Enter age for student 5: ");
        string age5 = Console.ReadLine();
        Console.WriteLine ("Enter age for student 6: ");
        string age6 = Console.ReadLine();
        Console.WriteLine ("Enter age for student 7: ");
        string age7 = Console.ReadLine();
        Console.WriteLine ("Enter age for student 8: ");
        string age8 = Console.ReadLine();
        Console.WriteLine ("Enter age for student 9: ");
        string age9 = Console.ReadLine();
        Console.WriteLine ("Enter age for student 10: ");
        string age10 = Console.ReadLine();
        
        double stu1 = double.Parse(age1);
        double stu2 = double.Parse(age2);
        double stu3 = double.Parse(age3);
        double stu4 = double.Parse(age4);
        double stu5 = double.Parse(age5);
        double stu6 = double.Parse(age6);
        double stu7 = double.Parse(age7);
        double stu8 = double.Parse(age8);
        double stu9 = double.Parse(age9);
        double stu10 = double.Parse(age10);
        
        double ageSum = stu1 + stu2 + stu3 + stu4 + stu5 + stu6 + stu7 + stu8 + stu9 + stu10;
        double ageResult = ageSum / 10;
        Console.WriteLine($"The average of the age of the students is: {ageResult}");
        
        bool isValidInput = false;

        while (!isValidInput)
        {
            Console.Write("Enter a number: ");

            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number) && number > 0)
            {
                isValidInput = true;

                Console.WriteLine("Output:");

                for (int i = 1; i <= number; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        
        isValidInput = false;
        
        while (!isValidInput)
        {
            Console.Write("Enter another number: ");

            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number) && number > 0)
            {
                isValidInput = true;

                int sum = number * (number + 1) / 2;

                Console.WriteLine("Output: " + sum);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        
        isValidInput = false;
        
        while (!isValidInput)
        {
            Console.Write("Enter another number: ");

            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number) && number > 0)
            {
                isValidInput = true;

                Console.WriteLine("Output:");

                for (int i = number; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}