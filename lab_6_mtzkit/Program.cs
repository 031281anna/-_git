using System;

namespace lab_6_mtzkit
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CNonRec(m, n));
            Console.WriteLine(CRec(m, n));
            Console.ReadKey();
        }
        static int Fact(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Fact(x - 1);
            }
        }
        static int CNonRec(int m, int n)
        {
            int C = Fact(m) / (Fact(n) * Fact(m - n));
            return C;
        }
        static int CRec(int m, int n)
        {
            if ((m <= 1) || (n == 0) || (n == m))
                return 1;
            else
                return CRec(m - 1, n - 1) + CRec(m - 1, n);
        }
        
    }
}

        
    

