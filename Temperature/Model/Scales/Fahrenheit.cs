﻿namespace Temperature.Model.Scales
{
    class Fahrenheit : IScale
    {
        public double ConvertFromCelsius(double celsiusDegrees)
        {
            return celsiusDegrees * 9 / 5 + 32;
        }

        public double ConvertToCelsius(double fahrenheitDegrees)
        {
            return (fahrenheitDegrees - 32) * 5 / 9;
        }
    }
}