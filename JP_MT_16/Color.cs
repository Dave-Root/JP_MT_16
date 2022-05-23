using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_MT_16
{
    enum Colors:int
    {
        red, green, blue, a
    }


    enum ErrorCode : ushort
    {
        None = 0,
        Unknown = 1000,
        ConnectionLost = 100,
        OutlierReading = 200
    }

    internal class Color: Object
    {

        public Colors C { get; set; }
        public Color()
        {
            
        }



        public void CreateNewColor()
        {
            Console.WriteLine($"rgb({(int)Colors.red}, {(int)Colors.green}, {(int)Colors.blue})");
        }  
        
        public void PrintErrorCode(ErrorCode error)
        {

            
            Console.WriteLine($"eror code is {(int)error}");
        }

        public override string ToString()
        {
            return "this object is color and using to create new colors";
        }

    }
}
