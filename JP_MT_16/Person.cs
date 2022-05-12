using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_MT_16
{
    internal class Person
    {
        private int Id { get; } =new Random().Next(1,100);
        public string Name { get; set; }
        public int Age { get; set; }

        public void TellMeYourId()
        {
            Console.WriteLine($"My Id is {Id}");
        }
        
        public bool IsAdult()
        {

            if(Age>17)
                return true;
            else
            {
        return false;
            }
        }
    }
}
