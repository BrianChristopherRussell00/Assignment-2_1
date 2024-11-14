using System;
using System.Globalization;

namespace Assignment_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Student Brian = new Student();
            string studentFirstName = Brian.FirstName = "Brian";
            string studentLastName = Brian.LastName = "Russell";
            int studentIdExample = Brian.StudentId = 1;
            char studentGradeAverage = Brian.Grade = 'B';

            Console.WriteLine($"Hello {studentFirstName} {studentLastName}");
            Console.WriteLine(Brian.StudentId);
            Console.WriteLine(Brian.Grade);

            Console.WriteLine("Select your desired operation: ");
            Console.WriteLine("a.Add(int num1, int num2");
            Console.WriteLine("b.Add(decimal num1, decimal num2, decimal num3");
            Console.WriteLine("c.Multiply(float num1, float num2");
            Console.WriteLine("d.Multiply(float num1, float num2, float num3");
            string desiredOperation = Console.ReadLine();

            switch (desiredOperation)
            {
                case "A":
                case "a":

                    Console.WriteLine("You've selected add!");
                    Console.WriteLine("Give me two values");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Maths.MathOperation(num1 ,num2));

                    break;

                case "B":
                case "b":

                    Console.WriteLine("You've selected add!");
                    Console.WriteLine("Give me three values");
                    decimal numberValueOneB = Convert.ToDecimal(Console.ReadLine());
                    decimal numberValueTwoB = Convert.ToDecimal(Console.ReadLine());
                    decimal numberValueThreeB = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine(Maths.MathOperation(numberValueOneB,numberValueTwoB,numberValueThreeB));

                    break;

                case "C":
                case "c":

                    Console.WriteLine("You've selected multiply!");
                    Console.WriteLine("Give me two values");
                    float numberValueOneC = Convert.ToChar(Console.ReadLine());
                    float numberValueTwoC = Convert.ToChar(Console.ReadLine());

                    Console.WriteLine(Maths.MathOperation(numberValueOneC, numberValueTwoC));
                    break;

                case "D":
                case "d":

                    Console.WriteLine("You've selected multiply!");
                    Console.WriteLine("Give me three values");
                    float numberValueOneD = Convert.ToChar(Console.ReadLine());
                    float numberValueTwoD = Convert.ToChar(Console.ReadLine());

                    float numberValueThreeD = Convert.ToChar(Console.ReadLine());

                    Console.WriteLine(Maths.MathOperation(numberValueOneD,numberValueTwoD,numberValueThreeD));


                    break;


                default:
                    Console.WriteLine("This is not a valid choice. Goodbye!");
                    Console.ReadLine();
                    break;



            }
        }
    }
}
//2.1 Part 2
// Child
// Parent
//(Household Types) MotherOnly, FatherOnly, BothParents
// (MotherOnly Branch) :Jane, Lady, Mary
//(FatherOnly Branch) : Willie, Kyle, John