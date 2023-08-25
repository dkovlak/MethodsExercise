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

            var result = (userAnswer == "Yes") ? "Congratulations! To claim your prize, please enter your card number, expiration date (EXP), and CVV code:" : "Understood. If you change your mind, feel free to enter your card information to participate:";
            Console.WriteLine(result);

            var userCardNumber = Console.ReadLine();
            var userEXP = Console.ReadLine();
            var userCVV = Console.ReadLine();

            Console.WriteLine("Thank you for your submission! Please remember to only share your card information with trusted sources. Have a wonderful day! Well, I went shopping :)");

           
         

        }
    }
}
