using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Car: Vehicle
    {
        // Const milage lifetime of maintance items for cars.

        // Values have been greatly reduced below real life recommendations to improve app testing experience.
        private const double OIL_LIFE_CAR = 1000;
        private const double BREAK_LIFE_CAR = 2000;
        private const double TIRE_LIFE_CAR = 3000;

        // Constructor
        public Car()
        {
            baseCost = 25865;   // Mid-size car: https://mediaroom.kbb.com/2018-02-01-Average-New-Car-Prices-Rise-Nearly-4-Percent-For-January-2018-On-Shifting-Sales-Mix-According-To-Kelley-Blue-Book
            fuelCapacity = 14.0;    // Car average: https://www.quickenloans.com/blog/cost-fill
            FuelCurrent = FuelCapacity;
            mpg = 24;   // Average: https://en.wikipedia.org/wiki/Fuel_efficiency#Fuel_efficiency_of_motor_vehicles
            TireCondition = TIRE_LIFE_CAR;
            BreakCondition = BREAK_LIFE_CAR;
            OilCondition = OIL_LIFE_CAR;
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
            OilCondition = OIL_LIFE_CAR;
            return 40;
        }
        public override double ReplaceBreaks()
        {
            BreakCondition = BREAK_LIFE_CAR;
            return 300;
        }
        public override double ReplaceTires()
        {
            TireCondition = TIRE_LIFE_CAR;
            return 637;
        }
    }
}
