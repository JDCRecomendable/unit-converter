namespace UnitConverter
{
    /// <summary>
    /// Class definition that is the basis for units used in the converter.
    /// </summary>
    public class Unit
    {
        private readonly string name;
        private readonly double gradient;
        private readonly double intercept;

        /// <summary>
        /// Construct a new Unit object.
        /// <para>
        /// The user should define the gradient and the y-intercept of a unit
        /// relative to the S.I. unit for the physical quantity that the unit
        /// represents.
        /// </para>
        /// <para>
        /// S.I. Value = Gradient * User Input + Intercept
        /// </para>
        /// </summary>
        public Unit(string pName, double pGradient, double pIntercept)
        {
            name = pName;
            gradient = pGradient;
            intercept = pIntercept;
        }

        /// <summary>
        /// Return the exact name of the unit.
        /// </summary>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Return the gradient of the unit relative to the S.I. unit for the
        /// physical quantity that the unit represents.
        /// </summary>
        public double GetGradient()
        {
            return gradient;
        }

        /// <summary>
        /// Return the y-intercept of the unit relative to the S.I. unit for
        /// the physical quantity that the unit represents.
        /// </summary>
        public double GetIntercept()
        {
            return intercept;
        }

        /// <summary>
        /// Return the number of S.I. units for the number of this unit
        /// entered. Needed for the calculation process.
        /// </summary>
        public double ConvertToSiValue(double value)
        {
            return (value * gradient + intercept);
        }

        /// <summary>
        /// Return the number of this units for the number of S.I. units
        /// entered. Needed for the calculation process.
        /// </summary>
        public double ConvertFromSiValue(double value)
        {
            return ((value - intercept) / gradient);
        }
    }
}