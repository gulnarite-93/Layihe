using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layihe.Models
{
    public abstract class Vehicle
    {
        private string _brand;
        public string Brand 
        {
            
            get { return _brand; }


            set { if (value.Length > 3 && value.Length < 30)
                    _brand = value;
                else { Console.WriteLine("duzgun deyil"); }
                    
                  }
        
        }



        private string _model;
        public string Model
        {

            get { return _model; }


            set
            {
                if (value.Length > 3 && value.Length < 30)
                    _brand = value;
                else { Console.WriteLine("sehvdir"); }

            }

        }

        private double _mile;
        public double Mile
        {

            get { return -_mile; }


            set
            {
                if (value >0)
                    _mile = value;
                else { Console.WriteLine("sehv"); }

            }

        }
        public Vehicle(string brand,string model,double mile)
        {
            Brand=brand;
            Model=model;
            Mile=mile;
        }

    }
}
