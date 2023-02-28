using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПрР1_Арефьева
{
    public class MatrixCreation
    {
        public MatrixCreation(int i, int j)
        {
            int n = i;
            int m = j;

            int num = 0;
            double k;

            Console.WriteLine("матрица размерности:");
            for (int ii = 0; ii < n; ii++)
            {
                Console.WriteLine();
                for (int jj = 0; jj < m; jj++)
                {
                    k = Math.Round(Math.Sin((ii + jj) / 2));
                    if (k > 0) num += 1;
                    Console.Write(k + "\t");
                }
            }
            Console.WriteLine();

            MATRIX(num);

            Console.WriteLine("число положительных чисел = {0} ", num);
            Console.ReadKey();
        }

        public int MATRIX(int number)
        {
            return number;
        }
    }
}
