using System;

namespace Program
{
    class DayKeeper
    {
        private int days;

        public DayKeeper(int days)
        {
            this.days = days;
        }

        public string getYearWeekDays()
        {
            int tempDays = days;
            int year = tempDays / 365;
            tempDays = tempDays % 365;
            int weeks = tempDays / 7;
            tempDays = tempDays % 7;
            return $"{year} years, {weeks} weeks, {tempDays} days";
        }

        public int Date
        {
            get
            {
                return this.days;
            }
            set
            {
                if (value > 0)
                    this.days = value;
                else
                    throw new ArgumentException("Days cant be negative");
            }
        }
    }

    class Driver
    {
        static void Main(string[] args)
        {
            DayKeeper dk = new DayKeeper(1456);
            Console.WriteLine(dk.getYearWeekDays());
        }
    }
}