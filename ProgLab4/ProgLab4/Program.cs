using System;

namespace ProgLab4
{
    class Program
    {

        static void Main(string[] args)
        {
            Input input = new Input();

            Matrix matrix1 = input.GetMatrix();
            Matrix matrix2 = input.GetMatrix();
            Matrix matrix3 = matrix1 + matrix2;

            Console.WriteLine(matrix1.GetMatrixText("Matrix1: "));
            Console.WriteLine(matrix2.GetMatrixText("Matrix2: "));
            Console.WriteLine(matrix3.GetMatrixText("Matrix3( Matrix1 + Matrix2 ): "));

            matrix3 *= matrix3;

            Console.WriteLine(matrix3.GetMatrixText("Matrix3( squared ): "));

            Console.WriteLine($"Result: {matrix3.GetNorm()}");
        }

    }
}
