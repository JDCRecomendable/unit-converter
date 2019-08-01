using System.Collections.Generic;

namespace UnitConverter
{
    /// <summary>
    /// Base class for grouping quantities
    /// </summary>
    public class UnitManipulator
    {
        private List<QuantityGroup> quantities = new List<QuantityGroup>();

        /// <summary>
        /// Construct a UnitManipulator object. Required by the domain logic
        /// to use the units and the calculation functions in the front-end.
        /// </summary>
        public UnitManipulator()
        {
            for (ushort i = 0; i < 16; i++)
                quantities.Add(new QuantityGroup());
        }

        /// <summary>
        /// Add a unit to the pre-defined list for the respective physical
        /// quantity.
        /// </summary>
        /// <param name="quantityIndex"></param>
        /// <param name="unit"></param>
        public void _AddUnit(int quantityIndex, Unit unit)
        {
            quantities[quantityIndex]._AddUnit(unit);
        }

        /// <summary>
        /// Add a unit to the custom units list for the respective physical
        /// quantity.
        /// </summary>
        /// <param name="quantityIndex"></param>
        /// <param name="unit"></param>
        public void AddUnit(int quantityIndex, Unit unit)
        {
            quantities[quantityIndex].AddUnit(unit);
        }

        /// <summary>
        /// Remove a unit from the custom units list for the respective
        /// physical quantity.
        /// </summary>
        /// <param name="quantityIndex"></param>
        /// <param name="unit"></param>
        public void RemoveUnit(int quantityIndex, Unit unit)
        {
            quantities[quantityIndex].RemoveUnit(unit);
        }

        /// <summary>
        /// Remove multiple units from the custom units list for the
        /// respective physical quantity.
        /// </summary>
        /// <param name="quantityIndex"></param>
        /// <param name="units"></param>
        public void RemoveUnits(int quantityIndex, List<Unit> units)
        {
            foreach (Unit unit in units)
                quantities[quantityIndex].AddUnit(unit);
        }

        /// <summary>
        /// Return a list of Unit objects representing all pre-defined units
        /// for a particular physical quantity.
        /// </summary>
        /// <param name="quantityIndex"></param>
        /// <returns></returns>
        public List<Unit> GetPreDefinedUnits(int quantityIndex)
        {
            List<Unit> resultList = new List<Unit>();
            resultList.AddRange(quantities[quantityIndex].ListPreDefinedUnits());
            return resultList;
        }

        /// <summary>
        /// Return a list of Unit objects representing all custom units for
        /// a particular physical quantity.
        /// </summary>
        /// <param name="quantityIndex"></param>
        /// <returns></returns>
        public List<Unit> GetCustomUnits(int quantityIndex)
        {
            List<Unit> resultList = new List<Unit>();
            resultList.AddRange(quantities[quantityIndex].ListCustomUnits());
            return resultList;
        }

        /// <summary>
        /// Return a list of Unit objects representing all pre-defined and
        /// custom units for a particular physical quantity.
        /// </summary>
        /// <param name="quantityIndex"></param>
        /// <returns></returns>
        public List<Unit> GetAllUnits(int quantityIndex)
        {
            List<Unit> resultList = new List<Unit>();
            resultList.AddRange(quantities[quantityIndex].ListAllUnits());
            return resultList;
        }

        /// <summary>
        /// Return a Unit object based on name.
        /// <para>The user has to inputh the quantity index (i.e. the
        /// physical quantity that the unit represents) and the exact
        /// name of the unit in order to return the Unit object.</para>
        /// </summary>
        /// <param name="quantityIndex"></param>
        /// <param name="unitName"></param>
        /// <returns></returns>
        public Unit GetUnitByName(int quantityIndex, string unitName)
        {
            List<Unit> units = new List<Unit>();
            units.AddRange(GetAllUnits(quantityIndex));

            foreach (Unit unit in units)
            {
                if (unit.GetName() == unitName)
                    return unit;
            }

            return new Unit("EEE", 0, 0);
        }
    }

    /// <summary>
    /// Base class for grouping groups of units for a quantity
    /// </summary>
    internal class QuantityGroup
    {
        private UnitGroup preDefinedGroup = new UnitGroup();
        private UnitGroup customGroup = new UnitGroup();

        /// <summary>
        /// Add a unit to the pre-defined group.
        /// </summary>
        /// <param name="unit"></param>
        internal void _AddUnit(Unit unit)
        {
            preDefinedGroup.AddUnit(unit);
        }

        /// <summary>
        /// Add a unit to the custom units group.
        /// </summary>
        /// <param name="unit"></param>
        internal void AddUnit(Unit unit)
        {
            customGroup.AddUnit(unit);
        }

        /// <summary>
        /// Remove a unit from the custom units group.
        /// </summary>
        /// <param name="unit"></param>
        internal void RemoveUnit(Unit unit)
        {
            customGroup.RemoveUnit(unit);
        }

        /// <summary>
        /// Return a list of Unit objects representing all units from the
        /// pre-defined group.
        /// </summary>
        /// <returns></returns>
        internal List<Unit> ListPreDefinedUnits()
        {
            return preDefinedGroup.ListUnits();
        }

        /// <summary>
        /// Return a list of Unit objects representing all units from the
        /// custom units group.
        /// </summary>
        /// <returns></returns>
        internal List<Unit> ListCustomUnits()
        {
            return customGroup.ListUnits();
        }

        /// <summary>
        /// Return a list of Unit objects representing all units from both
        /// the pre-defined and custom units group.
        /// </summary>
        /// <returns></returns>
        internal List<Unit> ListAllUnits()
        {
            List<Unit> resultList = new List<Unit>();

            resultList.AddRange(ListPreDefinedUnits());
            resultList.AddRange(ListCustomUnits());

            return resultList;
        }
    }

    /// <summary>
    /// Base class for grouping units
    /// </summary>
    internal class UnitGroup
    {
        private List<Unit> unitList = new List<Unit>();

        /// <summary>
        /// Add the input unit to the object.
        /// </summary>
        internal void AddUnit(Unit unit)
        {
            unitList.Add(unit);
        }

        /// <summary>
        /// Remove the input unit from the object.
        /// </summary>
        internal void RemoveUnit(Unit unit)
        {
            unitList.Remove(unit);
        }

        /// <summary>
        /// Remove a list of all units contained in the object.
        /// </summary>
        internal List<Unit> ListUnits()
        {
            return unitList;
        }
    }
}