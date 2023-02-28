using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПрР1_Арефьева
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int i = 0;
            int j = 0;

            i = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");

            j = Convert.ToInt32(Console.ReadLine());

            var MC = new MatrixCreation(i, j);
        }
    }
}
