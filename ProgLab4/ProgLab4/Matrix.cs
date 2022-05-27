using System;
namespace ProgLab4
{
    public class Matrix
    {
        private int[,] _matrix;

        public Matrix(int[,] matrix)
        {
            _matrix = matrix;
        }

        public Matrix(int n, int value)
        {
            _matrix = new int[n, n];
            for (int i = 0; i < _matrix.GetLength(0); i++)
                for (int j = 0; j < _matrix.GetLength(1); j++)
                    _matrix[i, j] = value;
        }

        public Matrix(int n, int minValue, int maxValue)
        {
            _matrix = new int[n, n];
            Random random = new Random();

            for (int i = 0; i < _matrix.GetLength(0); i++)
                for (int j = 0; j < _matrix.GetLength(1); j++)
                    _matrix[i, j] = random.Next(minValue, maxValue + 1);
        }

        public double GetNorm()
        {
            double norm;
            double sum = 0;

            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    sum += Math.Pow(_matrix[i, j], 2);
                }
            }

            norm = Math.Sqrt(sum);

            return norm;
        }

        public int[,] GetMatrix()
        {
            return _matrix;
        }

        public void SetMatrix(int[,] matrix)
        {
            _matrix = matrix;
        }

        public string GetMatrixText(string caption = "")
        {
            string text = caption + "\n";

            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    text += _matrix[i, j] + " ";
                }
                text += "\n";
            }

            return text;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.GetMatrix().Length != b.GetMatrix().Length)
                return a;

            int[,] result = new int[a.GetMatrix().GetLength(0), a.GetMatrix().GetLength(1)];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = a.GetMatrix()[i, j] + b.GetMatrix()[i, j];
                }
            }

            return new Matrix(result);
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.GetMatrix().GetLength(1) != b.GetMatrix().GetLength(0))
                return a;

            int[,] result = new int[a.GetMatrix().GetLength(0), a.GetMatrix().GetLength(1)];
            int[,] aMatrix = a.GetMatrix();
            int[,] bMatrix = b.GetMatrix();

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    for (int k = 0; k < result.GetLength(1); k++)
                    {
                        result[i, j] += aMatrix[i, k] * bMatrix[k, j];
                    }
                }
            }

            return new Matrix(result);
        }
    }
}
