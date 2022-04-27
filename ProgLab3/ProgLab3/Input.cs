using System;

namespace ProgLab3
{
    public class Input
    {
        public int GetPolynomialsAmount()
        {
            int amount = 0;

            Console.WriteLine("Enter amount of polynomials: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                amount = result;
            }

            return amount;

        }

        public CubicPolynomial[] GetPolynomials(int amount)
        {
            CubicPolynomial[] cubicPolynomials = new CubicPolynomial[amount];

            Console.WriteLine("Enter polynomials coefficients (format: a3 a2 a1 a0): ");

            for (int i = 0; i < cubicPolynomials.Length; i++)
            {
                string input = Console.ReadLine();

                CubicPolynomial cubicPolynomial = CreatePolynomial(input);
                if (cubicPolynomial != null)
                {
                    cubicPolynomials[i] = cubicPolynomial;
                    Console.WriteLine(cubicPolynomials[i].GetPolynomial());
                }
                else
                {
                    Console.WriteLine("Error! Wrong format. Try again");
                    i--;
                }
            }

            return cubicPolynomials;
        }

        public float[] GetSegment()
        {
            float[] segment = new float[2];
            float result = 0;

            Console.WriteLine("Enter a: ");
            while(!float.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Error! Wrong format. Try again!");
            }
            segment[0] = result;

            Console.WriteLine("Enter b: ");
            while (!float.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Error! Wrong format. Try again!");
            }
            segment[1] = result;

            if(segment[0] > segment[1])
            {
                Console.WriteLine("a and b will be swapped, since a > b");
                float temp = segment[0];
                segment[0] = segment[1];
                segment[1] = temp;
            }


            return segment;
            
        }

        public float GetEpsilon()
        {
            Console.WriteLine("Enter epsilon: ");
            float result = 0;

            while (!float.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Error! Wrong format. Try again!");
            }

            return result;

        }

        private CubicPolynomial CreatePolynomial(string line)
        {
            float[] coefficients = new float[4];
            string[] elements = line.Split(" ");

            if (elements.Length != 4)
                return null;
            for (int i = 0; i < elements.Length; i++)
                if (float.TryParse(elements[i], out float result))
                    coefficients[i] = result;
                else
                    return null;

            return new CubicPolynomial(coefficients[3], coefficients[2], coefficients[1], coefficients[0]);


        }
    }
}
