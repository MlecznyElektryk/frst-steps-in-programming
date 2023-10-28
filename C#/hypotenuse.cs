using System.Diagnostics;

namespace hypotenuse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstCathetus, secondCathetus;

            Console.WriteLine("Hello! This program calculates the hypotenuse of a Pythagorean triangle." +
                "\nPlease type the length of the first cathetus:  ");

            firstCathetus = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please type the length of the second cathetus: ");

            secondCathetus = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The hypotenuse is equal to " +
                Math.Sqrt(Math.Pow(firstCathetus, 2) + Math.Pow(secondCathetus, 2)));

        }
    }
}