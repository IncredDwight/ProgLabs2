using System;

namespace ProgLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();

            CubicPolynomial[] cubicPolynomials = input.GetPolynomials(input.GetPolynomialsAmount());
            float[] segment = input.GetSegment();

            PolynomialManager polynomialManager = new PolynomialManager(segment[0], segment[1], input.GetEpsilon());

            Console.WriteLine("Result: " + polynomialManager.GetMin(cubicPolynomials));
        }
    }
}
