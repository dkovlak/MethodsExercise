namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //---------------------Exercise 1--------------------
            //Nickname: Bruh
            //Answer: Yes/No
            //Card Number: 3357 2894 3892 6678
            //EXP: 09/27
            //CVV: 052
            Console.WriteLine("Welcome! Please create a nickname:");
            var userName = Console.ReadLine();

            Console.WriteLine($"Wow, what a great name {userName}!,");
            Console.WriteLine($"Hello, {userName}! Would you like a chance to win $1,000,000?");
            var userAnswer = Console.ReadLine();

            var result = (userAnswer == "Yes") ? "Congratulations! To claim your prize, please enter your card number, expiration date (EXP), and CVV code:"
                                               : (userAnswer == "yes") ? "Congratulations! To claim your prize, please enter your card number, expiration date (EXP), and CVV code:"
                                               : "Understood. If you change your mind, feel free to enter your card information to participate:";
            Console.WriteLine(result);

            var userCardNumber = Console.ReadLine();
            var userEXP = Console.ReadLine();
            var userCVV = Console.ReadLine();

            Console.WriteLine("Thank you for your submission! Please remember to only share your card information with trusted sources. Have a wonderful day! Well, I went shopping :)");

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"{userName}, Here is your information:");
            Console.WriteLine($"Nickname: {userName}");
            Console.WriteLine($"Card Number: {userCardNumber}");
            Console.WriteLine($"EXP: {userEXP}");
            Console.WriteLine($"CVV: {userCVV}");




            Console.WriteLine("--------------------Exercise 2--------------------");

            Console.WriteLine($"Addition: {Sum(5, 3, 8)} ");
            Console.WriteLine($"Subtraction: {Sub(8, 4, 1, 5, 5)}");
            Console.WriteLine($"Multiplication: {Multiply(5, 5, 5)}");
            Console.WriteLine($"Division: {Division(5, 6, 1, 8)}");
        }
            static int Sum(params int[] numbers)
            {
                int result = 0;
                foreach (int num in numbers) result += num;
                return result;
            }
            static int Sub(params int[] numbers)
            {
                int result = numbers[0];
                for (int bro = 1; bro < numbers.Length; bro++) result -= numbers[bro];
                return result;
            }
            static int Multiply(params int[] numbers)
            {
                int result = 1;
                foreach (int num in numbers) result *= num;
                return result;
            }
            static double Division(params double[] numbers)
            {
                double result = numbers[0];
                for (int bruh = 1; bruh < numbers.Length; bruh++) result /= numbers[bruh];
                return result;

            }
    }
}
