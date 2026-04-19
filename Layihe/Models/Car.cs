using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layihe.Models
{
    public class Car:Vehicle
    {
        private int _doorsNum;

        public int DoorsNum
        { 
            get { return _doorsNum; }
            set 
            {
                if (value > 0 && value < 5)
                    value = _doorsNum;

                else
                    Console.WriteLine("Sehv!");
            }

        }

      
        
        public Car(string brand,string model,double mile, int doorsNum):base(brand,model,mile)
        {
            doorsNum = DoorsNum;
        }


        public void ShowFullInfo()
        {
            Console.WriteLine(Brand + Model + Mile + DoorsNum);


        }




    }
}
