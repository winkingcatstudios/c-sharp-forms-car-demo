using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Motorcycle: Vehicle
    {
        // Const milage lifetime of maintance items for motorcycles.
        // Values have been greatly reduced below real life recommendations to improve app testing experience.
        private const double OIL_LIFE_MOTORCYCLE = 1233; // Reduced oil life for all vehicles to 1/3rd.  Motorcycle recommended every 3700 miles: http://www.elf.com/en/advice-corner/motorcycle-oil-faq/when-to-change-motorcycle-oil.html
        private const double BREAK_LIFE_MOTORCYCLE = 1500; // Brakes actually recommended every 20,000.  This is an arbitrary number.
        private const double TIRE_LIFE_MOTORCYCLE = 750; // Tire life on a motorcycle evidently is significantly less than a car: https://thebikersgarage.wordpress.com/2012/05/28/motorcycle-safety-tire-wear-bars/

        // Constructor
        public Motorcycle()
        {
            baseCost = 8375;   // Average of top 2 sellers: https://www.popularmechanics.com/cars/motorcycles/g2309/best-motorcycle-buys/
            fuelCapacity = 5.0;    // Motorcycle average: https://www.quickenloans.com/blog/cost-fill
            FuelCurrent = FuelCapacity;
            mpg = 56;   // Average: https://www.autoblog.com/2008/05/21/motorcycles-owners-report-average-of-56-miles-per-gallon/
            TireCondition = TIRE_LIFE_MOTORCYCLE;
            BreakCondition = BREAK_LIFE_MOTORCYCLE;
            OilCondition = OIL_LIFE_MOTORCYCLE;
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
            OilCondition = OIL_LIFE_MOTORCYCLE;
            return 90;
        }
        public override double ReplaceBreaks()
        {
            BreakCondition = BREAK_LIFE_MOTORCYCLE;
            return 200;
        }
        public override double ReplaceTires()
        {
            TireCondition = TIRE_LIFE_MOTORCYCLE;
            return 120;
        }
    }
}
