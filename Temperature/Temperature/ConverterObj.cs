using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class ConverterObj
    {
        private static double celsius2farenheit(double C) => (C * 9.0 / 5.0) + 32.0;

        private static double farenheit2celsiuse(double F) => (F - 32.0) * 5.0 / 9.0;

        private double celsiusValue;
        private double farenheitValue;


        public double CelsiusValue
        {
            get { return celsiusValue; }
            set { celsiusValue = value; farenheitValue = celsius2farenheit(value); }
        }

        public double FarenheitValue
        {
            get { return farenheitValue; }
            set { farenheitValue = value; celsiusValue = farenheit2celsiuse(value); }
        }
    }
}
