namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string whatToConvert;

            Start();

            void Start()
            {
                Console.WriteLine("What do you want to calculate?(Length, Temperature, Weight)");
                whatToConvert = Console.ReadLine();

                switch (whatToConvert)
                {
                    case "length":
                    case "Length":
                        Console.Clear();
                        Length length = new Length();
                        length.Start();
                        break;
                    case "temperature":
                    case "Temperature":
                        Console.Clear();
                        Temperature temperature = new Temperature();
                        temperature.Start();
                        break;
                    case "weight":
                    case "Weight":
                        Console.Clear();
                        Weight weight = new Weight();
                        weight.Start();
                        break;
                    default:
                        Console.Clear();
                        Start();
                        break;
                }

                Console.WriteLine("Do you want to use the converter again?");
                string input = Console.ReadLine().ToLower();

                if (input == "yes")
                {
                    Console.Clear();
                    Start();
                }
            }
        }
    }

    class Length()
    {
        string convertFrom;
        string convertTo;
        int convertFromInt;
        private bool tryAgain = true;

        public void Start()
        {
            Console.WriteLine("LENGTH");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("From what do you want to Convert?(M, cm, km, ft, mile, in)");
            convertFrom = Console.ReadLine();
            switch (convertFrom)
            {
                case "M":
                case "m":
                    Meter();
                    break;
                case "cm":
                case "CM":
                    CM();
                    break;
                case "km":
                case "KM":
                    KM();
                    break;
                case "mile":
                case "Mile":
                    Mile();
                    break;
                case "ft":
                case "FT":
                    FT();
                    break;
                case "in":
                case "IN":
                    IN();
                    break;
                default:
                    Console.Clear();
                    Start();
                    break;
            }
        }

        void Meter()
        {
            Console.WriteLine("Into what do you want to Convert?(cm, km, ft, mile, in)");
            convertTo = Console.ReadLine();

            while (tryAgain)
            {
                switch (convertTo)
                {
                    case "cm":
                    case "CM":
                        tryAgain = false;
                        Console.Write("Meter: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} meter's are {(double)convertFromInt * 100} centimeter's.");
                        break;
                    case "km":
                    case "KM":
                        tryAgain = false;
                        Console.Write("Meter: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} meter's are {(double)convertFromInt / 1000} kilometer's.");
                        break;
                    case "mile":
                    case "Mile":
                        tryAgain = false;
                        Console.Write("Meter: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} meter's are {(double)convertFromInt / 1609.34} mile's.");
                        break;
                    case "ft":
                    case "FT":
                        tryAgain = false;
                        Console.Write("Meter: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} meter's are {(double)convertFromInt * 3.28024} feet.");
                        break;
                    case "in":
                    case "IN":
                        tryAgain = false;
                        Console.Write("Meter: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} meter's are {(double)convertFromInt * 39.3701} inches.");
                        break;
                    default:
                        Meter();
                        break;
                }
            }
        }

        void CM()
        {
            Console.WriteLine("Into what do you want to Convert?(M, km, ft, mile, in)");
            convertTo = Console.ReadLine();

            while (tryAgain)
            {
                switch (convertTo)
                {
                    case "M":
                    case "m":
                        tryAgain = false;
                        Console.Write("Centimeter's: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} centimeter's are {(double)convertFromInt / 100} meter's.");
                        break;
                    case "km":
                    case "KM":
                        tryAgain = false;
                        Console.Write("Centimeter's: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} centimeter's are {(double)convertFromInt / 100000} kilometer's.");
                        break;
                    case "mile":
                    case "Mile":
                        tryAgain = false;
                        Console.Write("Centimeter's: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} centimeter's are {(double)convertFromInt / 160934.4} miles.");
                        break;
                    case "ft":
                    case "FT":
                        tryAgain = false;
                        Console.Write("Centimeter's: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} centimeter's are {(double)convertFromInt * 0.0328084} feet.");
                        break;
                    case "in":
                    case "IN":
                        tryAgain = false;
                        Console.Write("Centimeter's: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} centimeter's are {(double)convertFromInt * 0.393701} inches.");
                        break;
                    default:
                        CM();
                        break;
                }
            }
        }

        void KM()
        {
            Console.WriteLine("Into what do you want to Convert?(M, cm, ft, mile, in)");
            convertTo = Console.ReadLine();

            while (tryAgain)
            {
                switch (convertTo)
                {
                    case "M":
                    case "m":
                        tryAgain = false;
                        Console.Write("Kilometer's: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} kilometer's are {(double)convertFromInt * 1000} meter's.");
                        break;
                    case "cm":
                    case "CM":
                        tryAgain = false;
                        Console.Write("Kilometer's: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} kilometer's are {(double)convertFromInt * 100000} centimeter's.");
                        break;
                    case "mile":
                    case "Mile":
                        tryAgain = false;
                        Console.Write("Kilometer's: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} kilometer's are {(double)convertFromInt * 0.621371} miles.");
                        break;
                    case "ft":
                    case "FT":
                        tryAgain = false;
                        Console.Write("Kilometer's: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} kilometer's are {(double)convertFromInt * 3280.84} feet.");
                        break;
                    case "in":
                    case "IN":
                        tryAgain = false;
                        Console.Write("Kilometer's: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} kilometer's are {(double)convertFromInt * 39370.1} inches.");
                        break;
                    default:
                        KM();
                        break;
                }
            }
        }

        void Mile()
        {
            Console.WriteLine("Into what do you want to Convert?(M, cm, km, ft, in)");
            convertTo = Console.ReadLine();

            while (tryAgain)
            {
                switch (convertTo)
                {
                    case "M":
                    case "m":
                        tryAgain = false;
                        Console.Write("Miles: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} miles are {(double)convertFromInt * 1609.34} meters.");
                        break;
                    case "cm":
                    case "CM":
                        tryAgain = false;
                        Console.Write("Miles: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} miles are {(double)convertFromInt * 160934.4} centimeters.");
                        break;
                    case "km":
                    case "KM":
                        tryAgain = false;
                        Console.Write("Miles: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} miles are {(double)convertFromInt * 1.60934} kilometers.");
                        break;
                    case "ft":
                    case "FT":
                        tryAgain = false;
                        Console.Write("Miles: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} miles are {(double)convertFromInt * 5280} feet.");
                        break;
                    case "in":
                    case "IN":
                        tryAgain = false;
                        Console.Write("Miles: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} miles are {(double)convertFromInt * 63.360} inches.");
                        break;
                    default:
                        Mile();
                        break;
                }
            }
        }

        void FT()
        {
            Console.WriteLine("Into what do you want to Convert?(M, km, cm, mile, in)");
            convertTo = Console.ReadLine();

            while (tryAgain)
            {
                switch (convertTo)
                {
                    case "M":
                    case "m":
                        tryAgain = false;
                        Console.Write("Feet: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} feet are {(double)convertFromInt * 0.3048} meters.");
                        break;
                    case "cm":
                    case "CM":
                        tryAgain = false; 
                        Console.Write("Feet: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} feet are {(double)convertFromInt * 30.48} centimeters.");
                        break;
                    case "km":
                    case "KM":
                        tryAgain = false; 
                        Console.Write("Feet: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} feet are {(double)convertFromInt * 0.0003048} kilometers.");
                        break;
                    case "mile":
                    case "Mile":
                        tryAgain = false; 
                        Console.Write("Feet: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} feet are {(double)convertFromInt / 5280} miles.");
                        break;
                    case "in":
                    case "IN":
                        tryAgain = false; 
                        Console.Write("Feet: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} feet are {(double)convertFromInt * 12} inches.");
                        break;
                    default:
                        FT();
                        break;
                }
            }
        }

        void IN()
        {
            Console.WriteLine("Into what do you want to Convert?(M, cm, km, ft, mile)");
            convertTo = Console.ReadLine();

            while (tryAgain)
            {
                switch (convertTo)
                {
                    case "M":
                    case "m":
                        tryAgain = false;
                        Console.Write("Inches: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} inches are {(double)convertFromInt * 0.0254} meters.");
                        break;
                    case "cm":
                    case "CM":
                        tryAgain = false;
                        Console.Write("Inches: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} inches are {(double)convertFromInt * 2.54} centimeters.");
                        break;
                    case "km":
                    case "KM":
                        tryAgain = false;
                        Console.Write("Inches: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} inches are {(double)convertFromInt * 0.0000254} kilometers.");
                        break;
                    case "mile":
                    case "Mile":
                        tryAgain = false;
                        Console.Write("Inches: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} inches are {(double)convertFromInt / 63.36} miles.");
                        break;
                    case "ft":
                    case "FT":
                        tryAgain = false;
                        Console.Write("Inches: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} inches are {(double)convertFromInt / 12} feet.");
                        break;
                    default:
                        IN();
                        break;
                }
            }
        }
    }

    class Temperature()
    {
        string convertFrom;
        string convertTo;
        int convertFromInt;
        private bool tryAgain = true;

        public void Start()
        {
            Console.WriteLine("TEMPERATURE");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("From what do you want to Convert?(C, F, K)");
            convertFrom = Console.ReadLine().ToLower();

            switch (convertFrom)
            {
                case "c":
                    Celsius();
                    break;
                case "f":
                    Fahrenheit();
                    break;
                case "k":
                    Kelvin();
                    break;
                default:
                    Console.Clear();
                    Start();
                    break;
            }
        }

        void Celsius()
        {
            Console.WriteLine("Into what do you want to Convert?(F, K)");
            convertTo = Console.ReadLine();

            while (tryAgain)
            {
                switch (convertTo)
                {
                    case "f":
                        tryAgain = false;
                        Console.Write("Celsius: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} Celsius are {((double)convertFromInt * ((double)9 / 5)) + 32} Fahrenheit.");
                        break;
                    case "k":
                        tryAgain = false;
                        Console.Write("Celsius: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} Celsius are {(double)convertFromInt + 273.15} Kelvin.");
                        break;
                    default:
                        Celsius();
                        break;
                }
            }
        }

        void Fahrenheit()
        {
            Console.WriteLine("Into what do you want to Convert?(C, K)");
            convertTo = Console.ReadLine();

            while (tryAgain)
            {
                switch (convertTo)
                {
                    case "c":
                        tryAgain = false;
                        Console.Write("Fahrenheit: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} Fahrenheit are {((double)convertFromInt - 32) * ((double)5 / 9)} Celsius.");
                        break;
                    case "k":
                        tryAgain = false;
                        Console.Write("Fahrenheit: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} Fahrenheit are {(((double)convertFromInt - 32) * ((double)5 / 9)) + 273.15} Kelvin.");
                        break;
                    default:
                        Fahrenheit();
                        break;
                }
            }
        }

        void Kelvin()
        {
            Console.WriteLine("Into what do you want to Convert?(F, C)");
            convertTo = Console.ReadLine();

            while (tryAgain)
            {
                switch (convertTo)
                {
                    case "f":
                        tryAgain = false;
                        Console.Write("Kelvin: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} Kelvin are {(((double)convertFromInt - 273.15) * ((double)9 / 5)) + 32} Fahrenheit.");
                        break;
                    case "c":
                        tryAgain = false;
                        Console.Write("Kelvin: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} Kelvin are {(double)convertFromInt - 273.15} Celsius.");
                        break;
                    default:
                        Kelvin();
                        break;
                }
            }
        }
    }

    class Weight()
    {
        string convertFrom;
        string convertTo;
        int convertFromInt;
        private bool tryAgain = true;

        public void Start()
        {
            Console.WriteLine("WEIGHT");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("From what do you want to Convert?(st, lb, oz, kg, g)");
            convertFrom = Console.ReadLine().ToLower();

            switch (convertFrom)
            {
                case "st":
                    Stone();
                    break;
                case "lb":
                    Pound();
                    break;
                case "oz":
                    Ounce();
                    break;
                case "kg":
                    Kilogram();
                    break;
                case "g":
                    Gram();
                    break;
                default:
                    Console.Clear();
                    Start();
                    break;
            }
        }

        void Stone()
        {
            Console.WriteLine("Into what do you want to Convert?(lb, oz, kg, g)");
            convertTo = Console.ReadLine();

            while (tryAgain)
            {
                switch (convertTo)
                {
                    case "lb":
                        tryAgain = false;
                        Console.Write("Stone: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} Stone are {(double)convertFromInt * 12} Pounds.");
                        break;
                    case "oz":
                        tryAgain = false;
                        Console.Write("Stone: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} Stone are {(double)convertFromInt * 224} Ounces.");
                        break;
                    case "kg":
                        tryAgain = false;
                        Console.Write("Stone: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} Stone are {(double)convertFromInt * 6.35029} Celsius.");
                        break;
                    case "g":
                        tryAgain = false;
                        Console.Write("Stone: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} Stone are {(double)convertFromInt * 6350.29} Celsius.");
                        break;
                    default:
                        Stone();
                        break;
                }
            }
        }

        void Pound()
        {
            Console.WriteLine("Into what do you want to Convert?(st, oz, kg, g)");
            convertTo = Console.ReadLine();

            while (tryAgain)
            {
                switch (convertTo)
                {
                    case "st":
                        tryAgain = false;
                        Console.Write("Pound: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} Pound are {(double)convertFromInt * 12} Stone.");
                        break;
                    case "oz":
                        tryAgain = false;
                        Console.Write("Pound: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} Pound are {(double)convertFromInt * 224} Ounces.");
                        break;
                    case "kg":
                        tryAgain = false;
                        Console.Write("Pound: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} Pound are {(double)convertFromInt * 6.35029} Celsius.");
                        break;
                    case "g":
                        tryAgain = false;
                        Console.Write("Pound: ");
                        convertFromInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{convertFromInt} Pound are {(double)convertFromInt * 6350.29} Celsius.");
                        break;
                    default:
                        Stone();
                        break;
                }
            }
        }

        void Ounce()
        {

        }

        void Kilogram()
        {

        }

        void Gram()
        {

        }
    }
}
