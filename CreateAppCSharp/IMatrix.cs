using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAppCSharp
{
    public interface IMatrix<T>
    {
        T this[int row, int colum] { get; set; }

        void PrintMatrix();
    }
}
