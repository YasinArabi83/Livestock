using Livestock;

List<Animal> animals = new List<Animal>()
{
    new Cow()
    {
        IsFemale=false,IsMilk=false,Weight=1000,birthdate=new DateTime(2020,09,07),FoodVolume=50,
        Environments=new List<Livestock.Environment>()
        {
        new Livestock.Environment(){
            TDS= new HealthParameter<int>(){ Current = 6000 , Standard=5000, x = 0.1},
            Temperature=new HealthParameter<double>(){ Current = 25 , Standard=25, x=0.2},
            Density= new HealthParameter<int>(){Current =25  , Standard=37, x = 0.3},
            Decibel= new HealthParameter<double>(){Current = 80 , Standard=100, x = 0.1},
            AQI= new HealthParameter<int>(){Current = 80 , Standard=100, x = 0.2},
            Oxygen= new HealthParameter<int>(){Current = 35 , Standard=30, x = 0.1},
            Date=new DateTime(2023,12,12)
        }
        }


    },
    new Cow()
    {
        IsFemale=true,IsMilk=false,Weight=500,birthdate=new DateTime(2021,06,07),FoodVolume=44,
        Environments=new List<Livestock.Environment>()
        {
        new Livestock.Environment(){
            TDS= new HealthParameter<int>(){ Current = 6500 , Standard=5000, x = 0.1},
            Temperature=new HealthParameter<double>(){ Current = 30 , Standard=25, x=0.2},
            Density= new HealthParameter<int>(){Current =25  , Standard=37, x = 0.3},
            Decibel= new HealthParameter<double>(){Current = 80 , Standard=100, x = 0.1},
            AQI= new HealthParameter<int>(){Current = 80 , Standard=100, x = 0.2},
            Oxygen= new HealthParameter<int>(){Current = 35 , Standard=30, x = 0.1},
            Date=new DateTime(2023,12,12)
        }
        }


    },
    new Cow()
    {
        IsFemale=true,IsMilk=true,Weight=600,birthdate=new DateTime(2010,06,07),FoodVolume=40,
        Environments=new List<Livestock.Environment>()
        {
        new Livestock.Environment(){
            TDS= new HealthParameter<int>(){ Current = 6000 , Standard=5000, x = 0.1},
            Temperature=new HealthParameter<double>(){ Current = 26.5 , Standard=25, x=0.2},
            Density= new HealthParameter<int>(){Current =25  , Standard=37, x = 0.3},
            Decibel= new HealthParameter<double>(){Current = 80 , Standard=100, x = 0.1},
            AQI= new HealthParameter<int>(){Current = 80 , Standard=100, x = 0.2},
            Oxygen= new HealthParameter<int>(){Current = 35, Standard = 30, x = 0.1},
            Date=new DateTime(2023,12,12)
        }
        }


    },
    new Sheep()
    {
        IsFemale=true,IsMilk=true,Weight=300,birthdate=new DateTime(2020,06,07),FoodVolume=10,
        Environments=new List<Livestock.Environment>()
        {
        new Livestock.Environment(){
            TDS= new HealthParameter<int>(){ Current = 6000 , Standard=5000, x = 0.1},
            Temperature=new HealthParameter<double>(){ Current = 26.5 , Standard=25, x=0.2},
            Density= new HealthParameter<int>(){Current =12  , Standard=10, x = 0.3},
            Decibel= new HealthParameter<double>(){Current = 100 , Standard=100, x = 0.1},
            AQI= new HealthParameter<int>(){Current = 80 , Standard=100, x = 0.2},
            Oxygen= new HealthParameter<int>(){Current = 35, Standard = 30, x = 0.1},
            Date=new DateTime(2023,12,12)
        }
        }


    },

};





foreach (Animal animal in animals)
{
  Console.ForegroundColor =Color( animal.KillPriority());
    Console.WriteLine(animal.KillPriority());
    Console.WriteLine( animal.Life());
    Console.WriteLine(animal.TotalStress());
}

ConsoleColor Color(double Number)
{
    ConsoleColor FontColor = ConsoleColor.White;
    switch (Number)
    {
        case 1:
            FontColor = ConsoleColor.Gray;
            break;
        case 0.8:
            FontColor = ConsoleColor.DarkRed;
            break;
        case 0.6:
            FontColor = ConsoleColor.Red;
            break;
        case 0.4:
            FontColor = ConsoleColor.Yellow;
            break;
        case 0.2:
            FontColor = ConsoleColor.DarkGreen;
            break;
        case 0:
            FontColor = ConsoleColor.Green;
            break;
    }
    return FontColor;
}