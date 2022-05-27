using System;
namespace ProgLab5
{
    public class TPair
    {
        protected int _number1;
        protected int _number2;

        protected int _number1Min;
        protected int _number2Max;
        protected int _number2Min;

        public TPair(int number1, int number2)
        {
            AddNumber1(number1);
            AddNumber2(number2);
        }

        public void AddNumber1(int amount)
        {
            _number1 += amount;
        }

        public void ReduceNumber1(int amount)
        {
            _number1 -= amount;
            if (_number1 < _number1Min)
                _number1 = _number1Min;
        }

        public virtual void AddNumber2(int amount)
        {
            _number2 += amount;
        }

        public void ReduceNumber2(int amount)
        {
            _number2 -= amount;
            if (_number2 < _number2Min)
                _number2 = _number2Min;
        }

        public int GetNumber1()
        {
            return _number1;
        }

        public int GetNumber2()
        {
            return _number2;
        }

        public virtual string Display()
        {
            return _number1 + " " + _number2;
        }

    }

    public class TTime : TPair
    {
        public TTime(int number1, int number2) : base(number1, number2)
        {
            _number1Min = 0;
            _number2Max = 59;
            _number2Min = 0;
        }

        public override void AddNumber2(int amount)
        {
            base.AddNumber2(amount);
            if (_number2 > _number2Max)
            {
                _number2 = amount % 60;
                AddNumber1(amount / 60);
            }
        }

        public override string Display()
        {
            string minutes = (_number2 < 10) ? "0" + _number2 : _number2.ToString();
            return _number1 + ":" + minutes;
        }

    }

    public class TMoney : TPair
    {
        public TMoney(int number1, int number2) : base(number1, number2)
        {
            _number1Min = 0;
            _number2Max = 99;
            _number2Min = 0;
        }

        public override void AddNumber2(int amount)
        {
            base.AddNumber2(amount);
            if (_number2 > _number2Max)
            {
                _number2 = amount % 100;
                AddNumber1(amount / 100);
            }
        }

        public override string Display()
        {
            return $"{_number1}.{_number2}";
        }
    }
}
