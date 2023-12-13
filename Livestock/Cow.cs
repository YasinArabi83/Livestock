namespace Livestock
{
    class Cow : Animal
    {

        static Cow()
        {
            Maxlife = 9125;
            MeatPrice = 300000;
            FoodPrice = 20000;
        }

        public static int MeatPrice { get; set; }
        public static int FoodPrice {  get; set; }

        public static int Maxlife { get; }
        public bool IsMilk {  get; set; }
        public override int CostPerDay() =>
            FoodPrice * FoodVolume;
        

        public override double KillPriority()
        {
            double TimeToDie = Life();
            double KillPriority = 0;
            switch (TimeToDie)
            {
                case double x when (x < 8395 && IsFemale == false):
                   KillPriority = 1;
                    break;
                case double x when (IsMilk == false):
                    KillPriority = 1;
                    break;
                case double x when (x <= 1095):
                    KillPriority = 1;
                    break;
                case double x when (x > 1098 && x <= 2920):
                    KillPriority = 0.8;
                    break;
                case double x when (x > 2920 && x <= 4745):
                    KillPriority = 0.6;
                    break;
                case double x when (x > 4745 && x <= 6570):
                    KillPriority = 0.4;
                    break;
                case double x when (x > 6570 && x <= 8395):
                    KillPriority = 0.2;
                    break;
                default : KillPriority = 0;
                    break;

            }
            return KillPriority;
        }

        public override double Life()
        {
            double totalStress = TotalStress();
            int daysLived = (int)(DateTime.Now - birthdate).TotalDays;
            double life = Maxlife - (daysLived * totalStress);
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
