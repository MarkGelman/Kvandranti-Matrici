using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvandranti_Matrici
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] m = new int[2 * N, 2 * N];
            for (int i = 0; i < 2 * N; i++)
            {
                string [] s = Console.ReadLine().Split();
                for (int j = 0; j < 2*N; j++)
                    m[i, j] = int.Parse(s[j]);
            }
                
            int  d;
            for (int g = 0; g < N; g++)
            {
                for (int j = 0; j < N; j++)
                {
                    d = m[g, j];
                    m[g, j] = m[g+N, j];
                    m[g + N, j] = m[g + N, j + N];
                    m[g + N, j + N] = m[g, j + N];
                    m[g, j + N] = d;
                }
            }

            for (int i = 0; i < 2 * N; i++)
                for (int j = 0; j < 2 * N; j++)
                    if (j != 2 * N - 1)
                        Console.Write(m[i, j]+" ");
                    else
                        Console.WriteLine(m[i, j]);
        }
    }
}
