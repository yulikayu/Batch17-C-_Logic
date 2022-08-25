namespace Day01
{
    class ControlStatement
    {
        public static void ValidatePassword(string password)
        {
            if(password == null)
            {
                throw new ArgumentNullException("password required");
            }
            else if(password.Length <= 8)
            {
                Console.WriteLine("Your Passwaord is too short, at least 8 character");
            }
            else
            {
                Console.WriteLine("Your Password is strong");
            }
        }

        public static void EventNumber()
        {
            Console.Write("Enter a number  :");
            var input = Console.ReadLine();
            //int number=Convert.ToInt32(input);
            int.TryParse(input, out int number);
            if (number % 2 == 0)
            {
                Console.WriteLine("Event Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
          
        }

        public static void SwitchCase()
        {
            Console.WriteLine("enter number 1-10  :");
            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Smallest Number");
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                    Console.WriteLine("Event Number");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Odd Number");
                    break;
                case 10:
                    Console.WriteLine("Hight Number");
                    break;
                default:
                    Console.WriteLine("Not In ranges Number");
                    break;
            }
        }
       

    }
}