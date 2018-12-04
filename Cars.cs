using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Cars
    {
        public int horsepower;
        private string Make;
        public string color;
        public string year;
        public int speed;
        public string make { get; set; }
        public int Accelerate(int initSpeed)
        {
            return speed = initSpeed + 5;
        }
        public int Accerelate(int initspeed)
        {
            return speed = initspeed + 10;
        }
    }
    
}
