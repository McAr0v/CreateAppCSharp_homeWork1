using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CreateAppCSharp
{
    internal class Matrix<T> : IMatrix<T>
    {
        private T[,] _arr;
        public T this[int row, int column] {
            get => _arr[row, column];
            set => _arr[row, column] = value;
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < _arr.GetLength(0);  i++)
            {
                for (int j = 0; j < _arr.GetLength(1); j++)
                {
                    Console.Write($"{_arr[i, j]} ");
                }

                Console.WriteLine();
            }
        }

        public Matrix(int row, int column)
        {
            _arr = new T[row, column];
        }
    }
}
