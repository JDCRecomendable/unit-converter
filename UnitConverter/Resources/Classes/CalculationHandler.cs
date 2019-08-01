using System;

namespace UnitConverter
{
    /// <summary>
    /// Class definition to handle the calculation operations of the program.
    /// </summary>
    public class CalculationHandler
    {
        private short roundOffValue = -1;

        /// <summary>
        /// Return a double containing the calculation result.
        /// <para>The user should input the value to calculate, the "from unit" and
        /// "to unit".</para>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="fromUnit"></param>
        /// <param name="toUnit"></param>
        public double Calculate(double value, Unit fromUnit, Unit toUnit)
        {
            double intermediateResult;
            double result;

            intermediateResult = fromUnit.ConvertToSiValue(value);
            result = toUnit.ConvertFromSiValue(intermediateResult);

            if (roundOffValue > -1)
                return Math.Round(result, roundOffValue);

            return result;
        }

        /// <summary>
        /// Return the current precision setting for calculations.
        /// <para>-1 for not rounding off. 0 for round off to nearest whole
        /// number. 1 onwards for the number of decimal places.</para>
        /// </summary>
        public short GetRoundOffValue()
        {
            return roundOffValue;
        }

        /// <summary>
        /// Set the precision setting for calculations.
        /// <para>-1 for not rounding off. 0 for round off to nearest whole
        /// number. 1 onwards for the number of decimal places.</para>
        /// </summary>
        /// <param name="value"></param>
        public void SetRoundOffValue(short value)
        {
            roundOffValue = value;
        }
    }
}