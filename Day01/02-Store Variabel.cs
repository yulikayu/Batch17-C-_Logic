namespace Day01
{
    class StoreValiable
    {
        //01
        public static void StoreCharText()
        {
            //Store Character
            char letter = 'A';
            char digit = '1';
            char symbol = '$';
            Console.WriteLine($"{letter} {digit} {symbol}");

        }
        //02
        public static void StoreString()
        {
            string firstName = "Codeid";
            string lastName = "boocamp";
            Console.WriteLine(firstName + lastName);
        }
        //03 verbatin string
        
        public static void StoreVerbatim()
        {
            //literal string
            string fullName = "Yuli\t Cantik";

            //@ verbatin string :@ disable all escape character so blackslah
            string filePath = @"D:\\yuli\\C#\\01-Fundamental";

            Console.WriteLine($"{fullName}");
        }

        //04 store integer float double
        public static void StoreNumber()
        {
            //unsigned integer :positive whole number or 0
            uint naturalNumber = 23; 
            //integer : Negatve or positive whole number or 0
            int integerNumber = -23;

            //float means single precision floating point
            //F suffix makes it a loat literal
            float realNumber = 2.3f;

            //double :double precision floating poin
            double doubleNumber = 2.3; //double literal
        }
        //gunakan double or float real number that will not be compare for

        public static void ShouwDouble()
        {
            Console.WriteLine("Using Double : ");
            double a = 0.1;
            double b = 0.2;
            if (a + b == 0.3)
            {
                Console.WriteLine($"{a}+b equal {0.3}");
            }
            else
            {
                Console.WriteLine($"{a}+{b} does not equal {0.3}");
            }

        }

        public static void ShowDesimal()
        {
            decimal a = 0.1M; // M suffix to decimal value
            decimal b = 0.2M;
            if (a + b == 0.3M)
            {
                Console.WriteLine($"{a}+b equal {0.3}");
            }
            else
            {
                Console.WriteLine($"{a}+{b} does not equal {0.3}");
            }

        }

        public static void storeBoolean()
        {
            bool isStatus = true;
            bool isMarried = false;
        }
        public static void storeObject()
        {
            object obj = null;
            object firstName = "CodeId";
            //string itu adalaah tipenya objek
            //objek mampu menampung nilai apapun
            object height = 1.65;

            int lengtName = ((string)firstName).Length;

            Console.WriteLine($"{firstName} is {height} stress tall, LenghtFirstName :{lengtName} ");


        }
        //boxing dan unboxing, stack vs heap memory
        //
        public static void BoxingUnboxing()
        {

            int a = 42;
            object obj = a;

            obj = 45;
            int b = (int)obj;

            Console.WriteLine(a);
            Console.WriteLine(obj);
            Console.WriteLine(b);
            Console.WriteLine(a + a);


        }
        
        public static void ShowDataTypeRange()
        {
            Console.WriteLine($"sbyte {sbyte.MinValue} {sbyte.MaxValue}");
            Console.WriteLine($"int {int.MinValue} {int.MaxValue}");
            Console.WriteLine($"decimal {decimal.MinValue} {decimal.MaxValue}");
            Console.WriteLine($"Double {double.MinValue} {double.MaxValue}");
        }

        public static void ShowCasting()
        {
            //cast int to double
            int a = 10;
            double d = a;
            Console.WriteLine($"{d}");

            //cast double to int
            double c = 9.8;
            int b = (int)c;

            Console.WriteLine($"{b}");
        }

        public static void StoreDynamic()
        {
            //dynamic tidak punya method atau atribute yang bisa dipanggil jadi dia hanya mampu menyimpan data sementara

            dynamic myName = "Yuli Ayu";
            Console.WriteLine($"{myName}");
        }

        public static void StoreLocal()
        {
            int salary = 10_000_000; // hasilnya nnti yang keluar adalah 10.000.000
            double weight = 5.55; //in kg
            decimal price = 15.300M;//in IDR
            string myName = "Code.Id";
            char letter = 'Z';
            bool married = false;

            Console.WriteLine(salary);

        }
        public static void StoreVar()
        {
            var salary = 10_000_000; // hasilnya nnti yang keluar adalah 10.000.000
            var weight = 5.55; //in kg
            var price = 15.300M;//in IDR
            var myName = "Code.Id";
            var letter = 'Z';
            var married = false;

            /* Semua tipe data yang menggunakan var, harus ditetunkan valuenya
             tidak bisa dideklrasikan tanpa value*/

        }

        public static void PassingParams(string message)
        {
            Console.WriteLine($"Hello {message}");
        }

        public static void ShowNullableType()
        {
            //membuat default value adalah null dan ini cara pertama
            Nullable<int> a;
            Nullable<int> b = null;
            Nullable<int> c = 42;
            //ini cara kedua, kenapa dinull kan? karena type data primitif tidak ada yang null
            int? d;
            int? e = null;
            int f = 42;
            if (c.HasValue)
                Console.WriteLine(c.Value);

        }
        //date time
        public static void showDiffDate()
        {
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now.AddDays(10);
            DateTime.Compare(startDate, endDate);

        }
        public static void showArray()
        {
            int[] arr = new int[] { 1, 3, 4 };
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static void showList()
        {
            var number = new List<int>();
            number.Add(10);
            number.Add(15);

            foreach(var item in number)
            {
                Console.WriteLine(item);
            }
        }

        public static void showConsole()
        {
            int nummberOfIphone = 12;
            decimal pricePerIphone = 1.35M;

            Console.WriteLine(
                format:"{0} iphone cost {1:c}",
                arg0: nummberOfIphone,
                arg1: pricePerIphone = nummberOfIphone);

            // Interpolate string
            Console.WriteLine($"{nummberOfIphone} iphone cost {pricePerIphone = nummberOfIphone}");

        }

        public static void ReadConsole()
        {
            Console.Write("FirstName :");
            string? firsName =Console.ReadLine();

            Console.Write("Age :");
            string? age=Console.ReadLine();

            Console.WriteLine($"Hello {firsName}, you Look young for your {age}");
        }

        public static void ReadConsoleKey()
        {
            Console.Write("press c to continue or escp for cancle :");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            if(key.Key == ConsoleKey.C)
            {
                Console.WriteLine("Continue Process");

            }
            else if(key.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Quit Process");
            }

        }
    }
}