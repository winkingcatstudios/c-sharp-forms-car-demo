using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Suv: Vehicle
    {
        // Const milage lifetime of maintance items for SUVs.
        // Values have been greatly reduced below real life recommendations to improve app testing experience.
        private const double OIL_LIFE_SUV = 1000;
        private const double BREAK_LIFE_SUV = 1900; // I changed the brake life really just for the heck of it.  Probably doesn't really differ from a car.
        private const double TIRE_LIFE_SUV = 2100; // Same as before.  Changed this value just to differ from a car.

        // Constructor
        public Suv()
        {
            baseCost = 38153;   // Mid-size suv: https://mediaroom.kbb.com/2018-02-01-Average-New-Car-Prices-Rise-Nearly-4-Percent-For-January-2018-On-Shifting-Sales-Mix-According-To-Kelley-Blue-Book
            fuelCapacity = 22.0;    // Average: https://www.cars.com/articles/2017-mid-size-suv-driving-ranges-1420693064532/
            FuelCurrent = FuelCapacity;
            mpg = 20;   // Average: https://www.cars.com/articles/2017-mid-size-suv-driving-ranges-1420693064532/
            TireCondition = TIRE_LIFE_SUV;
            BreakCondition = BREAK_LIFE_SUV;
            OilCondition = OIL_LIFE_SUV;
            BreakAlert = OilAlert = TireAlert = false;
        }


        // Overloaded methods based on averages of vehicle type
        public override void Drive(double miles)
        {
            FuelCurrent -= (miles / mpg);
            TireCondition -= miles;
            if (TireCondition <= 0)
                TireAlert = true;
            BreakCondition -= miles;
            if (BreakCondition <= 0)
                BreakAlert = true;
            OilCondition -= miles;
            if (OilCondition <= 0)
                OilAlert = true;
        }
        // Sets conditions back to full lifespan and returns cost of maintance
        public override double ChangeOil()
        {
            OilCondition = OIL_LIFE_SUV;
            return 40;
        }
        public override double ReplaceBreaks()
        {
            BreakCondition = BREAK_LIFE_SUV;
            return 300;
        }
        public override double ReplaceTires()
        {
            TireCondition = TIRE_LIFE_SUV;
            return 800;
        }
    }
}
