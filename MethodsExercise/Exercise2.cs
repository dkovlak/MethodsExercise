namespace MethodsExercise
{
    public class Exercise2
    {
        private void Main(string[] args)
        {
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

