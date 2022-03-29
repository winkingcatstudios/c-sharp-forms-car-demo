using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Vehicle
    {
        // Const average cost of gas in Indianapolis, change as needed
        const double GASPRICE = 2.65;

        // Protected variables for read-only properties
        protected double baseCost; // Price of vehicle
        protected double fuelCapacity;
        protected double mpg;

        // Public properties
        public double BaseCost { get { return baseCost; } }
        public double FuelCurrent { get; set; }
        public double FuelCapacity { get { return fuelCapacity; } }
        public double Mpg { get { return mpg; } }
        public double TireCondition { get; set; }
        public double BreakCondition { get; set; }
        public double OilCondition { get; set; }
        public bool TireAlert { get; set; }
        public bool BreakAlert { get; set; }
        public bool OilAlert { get; set; }

        // Returns the cost of refueling to full based on gas prices and refuels
        public double AddFuel()
        {
            double cost = (FuelCapacity - FuelCurrent) * GASPRICE;
            FuelCurrent = FuelCapacity;
            return cost;
        }

        // Abstract methods, doubles returned are costs
        public abstract void Drive(double miles);
        public abstract double ChangeOil();
        public abstract double ReplaceBreaks();
        public abstract double ReplaceTires();
    }
}
