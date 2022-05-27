using System;
namespace ProgLab5
{
    public class Job
    {
        private TTime _time;
        private TMoney _price;

        public Job(TTime time, TMoney price)
        {
            _time = time;
            _price = price;
        }

        public TMoney GetTotalPrice()
        {
            int totalCoinsAmount = _price.GetNumber1() + _price.GetNumber2() * 100;
            int totalMinutesAmount = _time.GetNumber1() + _time.GetNumber2() * 60;

            return new TMoney(0, totalCoinsAmount * totalMinutesAmount);

        }

        public string Display()
        {
            return $"Time: {_time.Display()}\nPrice per minute: {_price.Display()}";
        }
    }
}
