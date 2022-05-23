using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_MT_16
{
    internal class Person
    {
        private int Id { get; set; }
        public string Name { get; set; }
        public  int Age { get; set; }

        public Person(int age)
        {
            Age = age;
            Id = new Random().Next(1, 100);
        }

        public void TellMeYourId()
        {
            Console.WriteLine($"My Id is {Id}");
        }
        
        public bool IsAdult()
        {

            if(Age>17)
                return true;
            else
                return false;
        }

        public static double Factorial(int number)
        {
            
            if (number == 0)
                return 1;
           

            double factorial = 1;
            for(int i = number; i>= 1; i--)
            {
                factorial *= i;
            }

            
            return factorial;
        }

    }
}
