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
        public int Age { get; set; }


        public Person(int age)
        {
            Id = new Random().Next(1, 100);
           
            Age = age;
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
    }
}
