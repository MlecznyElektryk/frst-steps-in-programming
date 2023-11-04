//Define an employee class with the appropriate structure:
//data(first name, last name, hourly rate, number of hours),
//methods(read(), payout(), display()).

namespace object_oriented_programming_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker_1 = new Worker(17.5, 40);
            worker_1.read();
            worker_1.display();
        }
    }
    class Worker
    {
        public string name;
        public string surname;
        public double hourlyRate;
        public double hour;
        public Worker(double hourlyRate, double hour)
        {
            this.hourlyRate = hourlyRate;
            this.hour = hour;
        }
        
        public double payout(double hours, double hourlyRate)
        {
            return hourlyRate * hours;
        }

        public void read()
        {
            Console.WriteLine("Type name: ");
            name = Console.ReadLine();
            Console.WriteLine("Type surname: ");
            surname = Console.ReadLine();
        }

        public void display()
        {
            Console.WriteLine($"{name} {surname} earned {payout(hour, hourlyRate)} zl");
        }
    }
}