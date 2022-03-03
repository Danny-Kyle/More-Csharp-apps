using System;

namespace ConsoleApp2
{
   /* class sample
    {
        public static void first()
        {
            Console.WriteLine("First mathod");
        }
        public void second()
        {
            first();
            Console.WriteLine("Second Method");
        }
        public void second(int i)
        {
            Console.WriteLine(i);
            second();
        }
    }
   /* class emp
    {
        public string name;
        public string address;
        public void display()
        {
            Console.WriteLine("{0} is in the city {1}",name ,address);
        }
    }*/
    class Program
    {
       /* public static void Main()
        {
            sample obj = new sample();
            sample.first();
            obj.second(10);
        }*/
        static void Main(string[] args)
        {
            /*emp obj = new emp();
            obj.name = "Falade";
            obj.address = "new dehli";
            obj.display();
            Console.ReadLine();*/
            //
            //
            //To find the standard deviation
             int n;
             float SD, sum, mean, variance, deviation, sum_sar;
             Console.Write("Enter no of Elements: ");
             n = int.Parse(Console.ReadLine());
             float[]num = new float[n];
             sum = 0;
             sum_sar = 0;
             Console.WriteLine("Input" + n + "values");
             for (int i = 0; i < n; i++)
             {
                 num[i] = float.Parse(Console.ReadLine());
                 sum += num[i];
             }
             mean = sum / (float)n;
             Console.WriteLine("Mean is"+mean);
             for (int i = 0; i < n; i++)
             {
                 deviation=num[i]-mean;
                 sum_sar += deviation * deviation;
             }
             variance = sum_sar/(float)n;
             SD = (float)Math.Sqrt(variance);
             Console.WriteLine("SD is"+SD);
             Console.ReadKey();
            
            //
            //
            //Rocket Launcher
            /*
            int n = -1;
            for (int i = 10; i > n; i--)
            {
                Console.WriteLine(i);
            }
            */
            //
            //
            //fname,sname,uname,concat,age,
            /*
            string firstname, surname, username;
            int birthyear,present_year,age;
            Console.WriteLine("Enter your firstname");
            firstname = Console.ReadLine();
            Console.WriteLine("Enter your Surname");
            surname = Console.ReadLine();
            Console.WriteLine("Enter your birthyear");
            birthyear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter current year");
            present_year = Convert.ToInt32(Console.ReadLine());
            age = present_year - birthyear;
            username = (surname +" "+ firstname);
            Console.WriteLine("Welcome " + username + "\nYou are " + age + " years old");
            Console.ReadKey();
            */
            //
            //
            //
            //generating a random number from 1 to 100
            /*
            Random random= new Random();
            int num = random.Next(1, 100);
            Console.WriteLine(num);
            */
            //
            //
            //
            //cELSIUS to fah
            /*
            double Celsius, fahrenheit;
            Console.WriteLine("Input Value in Celsius: ");
            Celsius = double.Parse(Console.ReadLine());
            fahrenheit = (Celsius * 9 / 5) + 32;
            Console.WriteLine(fahrenheit);
            */
            //
            //
        }
    }
}
