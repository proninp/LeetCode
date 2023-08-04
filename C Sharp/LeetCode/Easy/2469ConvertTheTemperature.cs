namespace LeetCode.Easy
{
    /*
     * 2469. Convert the Temperature
     * You are given a non-negative floating point number rounded to two decimal places celsius, that denotes the temperature in Celsius.
     * You should convert Celsius into Kelvin and Fahrenheit and return it as an array ans = [kelvin, fahrenheit].
     * Return the array ans. Answers within 10-5 of the actual answer will be accepted.
     */
    internal class _2469ConvertTheTemperature
    {
        public double[] ConvertTemperature(double celsius)
        {
            return new double[] { celsius + 273.15d, celsius * 1.8d + 32d };
        }
    }
}
