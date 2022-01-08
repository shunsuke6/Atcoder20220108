    using System;

    namespace A_WeirdFunction
    {
        class Program
        {
            static void Main(string[] args)
            {
                int t = int.Parse(Console.ReadLine());
                int res1 = Calc(t);
                int res2 = Calc(res1 + t);
                int res3 = Calc(Calc(t));

                int result = Calc(res2 + res3);            
                Console.WriteLine(result);
            }
            static int Calc(int t){
                return t*t + (2*t) + 3;
            }
        }
    }
