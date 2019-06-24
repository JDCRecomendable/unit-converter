using System;

namespace UnitConverter
{
    public class CalculationHandler
    {
        private short roundOffValue = -1;

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

        public short GetRoundOffValue()
        {
            return roundOffValue;
        }

        public void SetRoundOffValue(short value)
        {
            roundOffValue = value;
        }
    }
}