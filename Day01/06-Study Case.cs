namespace Day01
{
    class StudyCase
    {
        public static void GuessNumber()
        {
            Console.WriteLine("Guess magic Number between 0-20:");

            Random random = new Random();   
            int number =random.Next(0,20);

            int guess = -1;
            while (guess != number)
            {
                Console.WriteLine("enter your guess ?");
                var input =Console.ReadLine();
                int.TryParse(input, out guess);

                //check kondisi
                if(guess == number)
                {
                    Console.WriteLine($"Tebakanmu benar ,number :{guess}" );

                }
                else if(guess> number)
                {
                    Console.WriteLine("Your Guess is too Hight. Try Again");

                }
                else
                {
                    Console.WriteLine("Your Guess is too low. Try Again");
                }


            }

        }
    }
}