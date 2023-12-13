using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livestock
{
    abstract class Animal
    {
        static Animal() 
        { 
            TotalNum = 0;
        }
        protected Animal()
        {
            TotalNum++;
            Num = TotalNum;

        }
        public DateTime birthdate {  get; set; }
        public static int TotalNum { get; private set; }
        public int Num { get; private set; }
        public double Weight {  get; set; }
        public bool IsFemale {  get; set; }
        public int FoodVolume {  get; set; }
        public List<Environment> Environments { get; set; }
        public abstract double Life();
        public abstract double KillPriority();
        public abstract int CostPerDay();
        public abstract double TotalStress();
        public abstract double MeatValue();
    }
}
