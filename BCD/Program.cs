using System;

namespace BCD
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] v = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001" };
            Console.Write("Introduceti numarul: ");
            int nr = int.Parse(Console.ReadLine());
            int k = 10;
            int nrneg = 9;
            bool neg;

            if (nr >= 0)
                neg = false;
            else
            {
                neg = true;
                nr = nr * (-1);
            }
            int nr0 = 0;
            int nrrez = nr;
            int inv = nr % 10;
            while (nr / k > 0)
            {
                inv = inv * 10 + (nr / k) % 10;
                nrneg = nrneg * 10 + 9;
                k = k * 10;
                if (nrrez % 10 == 0)
                {
                    nr0++;
                    nrrez = nrrez / 10;
                }
            }

            if (neg)
            {
                nr = nrneg - inv;
                Console.Write(v[9] + " ");
            }
            else
            {
                nr = inv;
                Console.Write(v[0] + " ");
            }
            while (nr > 0)
            {
                Console.Write(v[nr % 10] + " ");
                nr = nr / 10;
            }
            for (int i = 0; i < nr0; i++)
            {
                Console.Write(v[0] + " ");
            }
            Console.ReadLine();
        }
    }
}
