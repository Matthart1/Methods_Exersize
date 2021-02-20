using System;

namespace Methods_MathClass
{
    class Program
    {
      
        static void Main(string[] args)
        {
            var result = Sum(10, 20);
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
            return answer;
        }

    } 
}
