namespace OperatorExercise
{
    public class Program
    {

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static void PrintAreaOfCircle()
        {
            Console.WriteLine("What is the radius of the circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with a radius of {radius} is {Math.Round(AreaOfCircle(radius), 2)}");
        }
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
            PrintAreaOfCircle();





        }
    }

}  


        
