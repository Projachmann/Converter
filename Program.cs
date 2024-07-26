namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string whatToConvert;
            Length length = new Length();
            Temperature temperature = new Temperature();
            Weight weight = new Weight();

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
                        length.Start();
                        break;
                    case "temperature":
                    case "Temperature":
                        Console.Clear();
                        temperature.Start();
                        break;
                    case "weight":
                    case "Weight":
                        Console.Clear();
                        weight.Start();
                        break;
                    default:
                        Console.Clear();
                        Start();
                        break;
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
                        break;
                    case "cm":
                    case "CM":
                        tryAgain = false;
                        break;
                    case "km":
                    case "KM":
                        tryAgain = false;
                        break;
                    case "ft":
                    case "FT":
                        tryAgain = false;
                        break;
                    case "in":
                    case "IN":
                        tryAgain = false;
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
                        break;
                    case "cm":
                    case "CM":
                        tryAgain = false;
                        break;
                    case "km":
                    case "KM":
                        tryAgain = false;
                        break;
                    case "mile":
                    case "Mile":
                        tryAgain = false;
                        break;
                    case "in":
                    case "IN":
                        tryAgain = false;
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
                        break;
                    case "cm":
                    case "CM":
                        tryAgain = false;
                        break;
                    case "km":
                    case "KM":
                        tryAgain = false;
                        break;
                    case "mile":
                    case "Mile":
                        tryAgain = false;
                        break;
                    case "ft":
                    case "FT":
                        tryAgain = false;
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
        public void Start()
        {

        }
    }

    class Weight()
    {
        public void Start()
        {

        }
    }
}
