using System;

namespace ProgLab3
{
    public class CubicPolynomial
    {
        private float _a0, _a1, _a2, _a3;

        public CubicPolynomial(float a0, float a1, float a2, float a3)
        {
            _a0 = a0;
            _a1 = a1;
            _a2 = a2;
            _a3 = a3;
        }

        public float GetValue(float x)
        {
            return (float)(_a3 * Math.Pow(x, 3) + _a2 * Math.Pow(x, 2) + _a1 * x + _a0);
        }

        public string GetPolynomial()
        {
            return $"{_a3}x^3 + {_a2}x^2 + {_a1}x + {_a0}";
        }
    }

    public class PolynomialManager
    {
        private float _a;
        private float _b;
        private float _epsilon;

        public PolynomialManager(float a, float b, float epsilon)
        {
            _a = a;
            _b = b;
            _epsilon = epsilon;
        }

        public float GetMin(CubicPolynomial[] polynomials)
        {
            float minValue = GetMinPolynomialValue(polynomials[0]);

            for (int i = 0; i < polynomials.Length; i++)
            {
                float minPolynomialValue = GetMinPolynomialValue(polynomials[i]);
                Console.WriteLine($"Min value in {polynomials[i].GetPolynomial()} is {minPolynomialValue}\n");
                
                if (minValue >= minPolynomialValue)
                    minValue = minPolynomialValue;
            }

            return minValue;
        }

        private float GetMinPolynomialValue(CubicPolynomial polynomial)
        {
            float minValue = polynomial.GetValue(_a);

            for (float i = _a; i <= _b; i += _epsilon)
            {
                float value = polynomial.GetValue(i);
                Console.WriteLine($"{polynomial.GetPolynomial()} with {i} value equals {value}");

                if (minValue >= value)
                    minValue = value;
            }

            return minValue;
        }
    }
}
