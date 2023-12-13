using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livestock
{
    class Sheep:Animal 
    {
        static Sheep() 
        {
            MaxLife = 4380;
            MeatPrice = 350000;
            FoodPrice = 10000;
            
        }
        public static int MaxLife { get; }

        public static int MeatPrice { get; set; }
        public static int FoodPrice { get; set; }

        public bool IsMilk { get; set; }
        public override int CostPerDay() =>
            FoodPrice * FoodVolume;


        public override double KillPriority()
        {
            double TimeToDie = Life();
            double KillPriority = 0;
            switch (TimeToDie)
            {
                case double x when (x < 3285 && IsFemale == false):
                    KillPriority = 1;
                    break;
                case double x when (IsMilk == false):
                    KillPriority = 1;
                    break;
                case double x when (x <= 365):
                    KillPriority = 1;
                    break;
                case double x when (x > 365 && x <= 1095):
                    KillPriority = 0.8;
                    break;
                case double x when (x > 1095 && x <= 1825):
                    KillPriority = 0.6;
                    break;
                case double x when (x > 1825 && x <= 2555):
                    KillPriority = 0.4;
                    break;
                case double x when (x > 2555 && x <= 3285):
                    KillPriority = 0.2;
                    break;
                default:
                    KillPriority = 0;
                    break;

            }
            return KillPriority;
        }

        public override double Life()
        {
            double totalStress = TotalStress();
            int daysLived = (int)(DateTime.Now - birthdate).TotalDays;
            double life = MaxLife - (daysLived * totalStress);
            return life;
        }

        public override double MeatValue() =>
            MeatPrice * Weight;




        public override double TotalStress()
        {
            double TotalStress = 0;
            foreach (var environment in Environments)
            {
                TotalStress += environment.TDS.SteressFactor() + environment.Temperature.SteressFactor() +
                environment.Density.SteressFactor() + environment.Decibel.SteressFactor() +
                environment.AQI.SteressFactor() + environment.Oxygen.SteressFactor();
            }
            return TotalStress;
        }
        public override string ToString() =>
            $"C{(IsFemale ? 'M' : 'F')}{birthdate.Year}{birthdate.Month}{birthdate.Day}{Num}";

    }
}
