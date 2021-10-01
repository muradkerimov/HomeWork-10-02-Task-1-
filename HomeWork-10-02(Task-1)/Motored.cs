using System;

namespace HomeWork_10_02_Task_1_
{
    class Motored
    {
        public string Model;
        public string Make;
        public int ProductionYear;
        public int FuelTankSize;
        public double FuelAmount;
        public double FuelUsedPerKm;
        public string Color;

        public Motored()
        {
            Console.WriteLine("Bir Motored yaradildi.");
        }


        public Motored(string model, string make,int productionYear)
        {
            Model =model;
            Make =make;
            ProductionYear = productionYear;
        }

        public Motored(string model, string make, int productionYear, int fuelTankSize, double fuelAmount, double fuelUsedPerKm, string color) : this(model, make, productionYear)
        {
            FuelTankSize = fuelTankSize;
            FuelAmount = fuelAmount;
            FuelUsedPerKm = fuelUsedPerKm;
            Color = color;
        }

      

        public string GetInfo()
        {
            return $"{Model} {Make}";
        }

        public virtual string GetDetailedInfo()
        {
            return $"{Model} {Make} {ProductionYear} {FuelTankSize} {FuelUsedPerKm} {Color}";
        }
    }
}
