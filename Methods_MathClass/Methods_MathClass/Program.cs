using System;

namespace Methods_MathClass
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of 10 plus 20 is...");
            Console.ReadLine();
            var result = Sum(10, 20);
            Console.ReadLine();

            Console.WriteLine("The result of 5 times 10 is...");
            Console.ReadLine();
            var math = Multiple(5, 10);
            Console.ReadLine();

            


        }   
        public static int Sum(int x, int y)
        {
            var answer = x + y;
            Console.WriteLine(answer);
            return answer;
        }
        public static int Multiple(int x, int y)
        {
            
            var answer = x * y;
            Console.WriteLine(answer);
            Console.ReadLine();
            Console.WriteLine("Great Job!!");
            return answer;
        }
        
    } 
}
