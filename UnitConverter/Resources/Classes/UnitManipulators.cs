using System.Collections.Generic;

namespace UnitConverter
{
    /// <summary>
    /// Base class for grouping quantities
    /// </summary>
    public class UnitManipulator
    {
        private List<QuantityGroup> quantities = new List<QuantityGroup>();

        public UnitManipulator()
        {
            for (ushort i = 0; i < 16; i++)
                quantities.Add(new QuantityGroup());
        }

        public void _AddUnit(int quantityIndex, Unit unit)
        {
            quantities[quantityIndex]._AddUnit(unit);
        }

        public void AddUnit(int quantityIndex, Unit unit)
        {
            quantities[quantityIndex].AddUnit(unit);
        }

        public void RemoveUnit(int quantityIndex, Unit unit)
        {
            quantities[quantityIndex].RemoveUnit(unit);
        }

        public void RemoveUnits(int quantityIndex, List<Unit> units)
        {
            foreach (Unit unit in units)
                quantities[quantityIndex].AddUnit(unit);
        }

        public List<Unit> GetPreDefinedUnits(int quantityIndex)
        {
            List<Unit> resultList = new List<Unit>();
            resultList.AddRange(quantities[quantityIndex].ListPreDefinedUnits());
            return resultList;
        }

        public List<Unit> GetCustomUnits(int quantityIndex)
        {
            List<Unit> resultList = new List<Unit>();
            resultList.AddRange(quantities[quantityIndex].ListCustomUnits());
            return resultList;
        }

        public List<Unit> GetAllUnits(int quantityIndex)
        {
            List<Unit> resultList = new List<Unit>();
            resultList.AddRange(quantities[quantityIndex].ListAllUnits());
            return resultList;
        }

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

        internal void _AddUnit(Unit unit)
        {
            preDefinedGroup.AddUnit(unit);
        }

        internal void AddUnit(Unit unit)
        {
            customGroup.AddUnit(unit);
        }

        internal void RemoveUnit(Unit unit)
        {
            customGroup.RemoveUnit(unit);
        }

        internal List<Unit> ListPreDefinedUnits()
        {
            return preDefinedGroup.ListUnits();
        }

        internal List<Unit> ListCustomUnits()
        {
            return customGroup.ListUnits();
        }

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