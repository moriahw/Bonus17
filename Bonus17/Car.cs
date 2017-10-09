using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class Car
    {
        //members
        private string make;
        private string model;
        private int year;
        private double price;

        //properties 
        public string Make
        {
            set { make = value; }
            get { return make; }
        }

        public string Model
        {
            set { model = value; }
            get { return model; }
        }

        public int Year
        {
            set { year = value; ; }
            get { return year; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }

        //constructors
        public Car() //default 
        {
            make = " ";
            model = " ";
            year = 0;
            price = 0;
        }

        public Car(string CarMake, string CarModel, int CarYear, double CarPrice)
        {
            make = CarMake;
            model = CarModel;
            year = CarYear;
            price = CarPrice;
        }
    }
}
