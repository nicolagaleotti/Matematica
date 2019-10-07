using System;

namespace OperazioniMatematica
{
    public class OperazioniMatematica
    {
        public static int Somma(int a, int b)
        {
            int s = a + b;
            return s;
        }
        public static int Differenza(int a, int b)
        {
            int d = a - b;
            return d;
        }
        public static int Moltiplicazione(int a, int b)
        {
            int p = a * b;
            return p;
        }
        public static double Divisione(double a, double b)
        {
            if (b <= 0)
            {
                throw new Exception("Il divisore non può essere uguale o minore di 0!");
            }
            else
            {
                double q = a / b;
                return q;
            }
        }
        public static long Potenza(int a, int b)
        {
            int c = 0;
            long p = 1;
            while (c < b)
            {
                p = p * a;
                c++;
            }
            return p;
        }
        public static int Minimo(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static int Massimo(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
         public static int CalcolaMetà (int a)
        {
            if (a % 2 == 0)
            {
                a = a / 2;
            }
            else
            {
                throw new Exception("Il numero è dispari");
            }
            return a;
        }
         public static bool Uguali (int a,int b,int c)
        {
            return a == b && b == c;
        }
    }
}
