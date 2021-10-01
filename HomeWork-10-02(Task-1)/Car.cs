using System;

namespace HomeWork_10_02_Task_1_
{
    class Car : Motored
    {
        public int HorsePower;
        public double MotorSize;
        public string Transmission;
        public int PassangerCount;
        public bool IsOn;

        public Car(string model, string make, int productionYear):base( model,  make,  productionYear)
        {

        }

        public Car(string model, string make, int productionYear,int fuelTankSize, double fuelAmount, double fuelUsedPerKm,string color, int horsePower, double motorSize, string transmission, int passangerCount, bool isOn) : base(model, make, productionYear,  fuelTankSize , fuelAmount,  fuelUsedPerKm,  color)
        {
            HorsePower = horsePower;
            MotorSize = motorSize;
            Transmission = transmission;
            PassangerCount = passangerCount;
            IsOn = isOn;
        }

        public void TurnOn(bool IsOn)
        {
            if (IsOn==true)
            {
                Console.WriteLine("masin islek vezyetdedir");
            }
                Console.WriteLine("masin islek vezyyetde deyil");
        }
        public void TurnOff(bool IsOn)
        {
            if (IsOn == false)
            {
                Console.WriteLine("masin islek vezyetdedir");
            }
            Console.WriteLine("masin islek vezyyetde deyil");
        }



        public void Go(double distance)
        {
            if (IsOn == true && distance <= FuelAmount / FuelUsedPerKm)
            {
                Console.WriteLine($"{distance}km qeder yol gedildi");
                FuelAmount = FuelAmount - distance * FuelUsedPerKm;
            }
            else
            {
                Console.WriteLine("masin gede bilmez");
            }
        }

        public override string GetDetailedInfo()
        {
            base.GetDetailedInfo();
            return $"{FuelAmount}";
        }
    }
}
