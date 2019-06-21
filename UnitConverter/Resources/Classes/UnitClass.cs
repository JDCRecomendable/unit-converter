namespace UnitConverter
{
    /// <summary>
    /// Class definition that is the basis for units used in the converter.
    /// <para>
    /// The user should define the gradient and the y-intercept of a unit
    /// relative to the S.I. unit for the unit type of the unit to be defined.
    /// </para>
    /// <para>
    /// S.I. Value = Gradient * User Input + Intercept
    /// </para>
    /// </summary>
    public class Unit
    {
        private readonly string name;
        private readonly double gradient;
        private readonly double intercept;

        public Unit(string pName, double pGradient, double pIntercept)
        {
            name = pName;
            gradient = pGradient;
            intercept = pIntercept;
        }

        public string GetName()
        {
            return name;
        }

        public double GetGradient()
        {
            return gradient;
        }

        public double GetIntercept()
        {
            return intercept;
        }

        public double ConvertToSiValue(double value)
        {
            return (value * gradient + intercept);
        }

        public double ConvertFromSiValue(double value)
        {
            return ((value - intercept) / gradient);
        }
    }
}