using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name
            //Favorite color
            //Favorite animal
            //Favorite band
            Console.WriteLine("What is your first name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hey there, {userName}, How old are you?");
            int userAge = int.Parse(Console.ReadLine());


            Console.WriteLine($"{userAge} is a good age! What is your favorite animal?");
            string userAnimal = Console.ReadLine();

            Console.WriteLine("Nice! Now, what is your favorite band?");
            string userBand = Console.ReadLine();


            Console.WriteLine($"Once there was a person named {userName} and they were {userAge} years old.");
            Console.WriteLine($"Wouldn't it be cool to have a {userAnimal} as a pet? Or how about going to see {userBand} live?!");


            Modulus(25, 30);
            Add(10, 40);
            Subtract(20, 10);





        }



        public static int Add (int x, int y)
        {
            int answer = x + y;
            return answer;
        }


        public static int Subtract (int x, int y)
        {
            int answer = x - y;
            return answer;
        }

        public static int Multiply (int x, int y)
        {
            int answer = x * y;
            return answer;
        }


        public static int Divide (int x, int y)
        {
            int answer = x / y;
            return answer;
        }



        public static int Modulus (int x, int y)
        {
            int answer = x % y;
            return answer;
        }



    }
}
