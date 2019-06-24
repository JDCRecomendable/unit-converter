namespace UnitConverter
{
    public static class PreDefinedUnitsLoader
    {
        private static readonly double pi = 3.1415926535897932384626433832795d;

        public static UnitManipulator LoadAllPreDefinedUnits(UnitManipulator unitManipulator)
        {
            // Length (22 units)
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Metre [m] (S.I. Unit)", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Nautical Mile [nmi]", 1852d, 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Hectometre [hm]", 100d, 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Kilometre [km]", 1000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Decimetre [dm]", 0.1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Centimetre [cm]", 0.01d, 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Millimetre [mm]", 0.001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Micrometre [μm]", 0.000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Nanometre [nm]", 0.000000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Ångström [Å]", 0.0000000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Mile [mi]", ((1d / 3.280839895d) * 5280d), 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Furlong", ((1d / 3.280839895d) * 660d), 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Chain", ((1d / 3.280839895d) * 66d), 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Rod", ((1d / 3.280839895d) * 16.5d), 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Horse Length", ((1d / 3.280839895d) * 8d), 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Fathom", ((1d / 3.280839895d) * 6d), 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Yard [yd]", ((1d / 3.280839895d) * 3d), 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Foot [ft]", (1d / 3.280839895d), 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Inch [in]", ((1d / 3.280839895d) / 12d), 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Astronomical Unit", 149597900000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Light-Year", 9460730000000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.length, new Unit("Parsec", 30856782064650000d, 0d));


            // Area (20 units)
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Square Metre [m²] (S.I. Unit)", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Square Kilometre [km²]", 1000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Square Decimetre [dm²]", 0.01d, 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Square Centimetre [cm²]", 0.0001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Square Millimetre [mm²]", 0.000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Square Micrometre [μm²]", 0.000000000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Are [a]", 100d, 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Stremma", 1000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Hectare [ha]", 10000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Tetrad", 4000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Hectad", 100000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Myriad", 10000000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Square Mile [mi²]", ((1d / 1.19599004630108d) * 3097600d), 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Square Yard [yd²]", (1d / 1.19599004630108d), 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Square Foot [ft²]", ((1d / 1.19599004630108d) / 9d), 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Square Inch [in²]", ((1d / 1.19599004630108d) / 1296d), 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Acre [ac]", ((1d / 1.19599004630108d) * 4840d), 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Rood", ((1d / 1.19599004630108d) * 1210d), 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Section", ((1d / 1.19599004630108d) * 3097600d), 0d));
            unitManipulator._AddUnit(QuantityIndex.area, new Unit("Survey Township", ((1d / 1.19599004630108d) * 111513600d), 0d));


            // Volume (15 units)
            unitManipulator._AddUnit(QuantityIndex.volume, new Unit("Cubic Metre [m³] (S.I. Unit)", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.volume, new Unit("Cubic Centimetre [cm³]", 0.000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.volume, new Unit("Cubic Millimetre [mm³]", 0.000000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.volume, new Unit("Cubic Yard [yd³]", (1d / 1.30795061931439d), 0d));
            unitManipulator._AddUnit(QuantityIndex.volume, new Unit("Cubic Foot [ft³]", ((1d / 1.30795061931439d) / 27d), 0d));
            unitManipulator._AddUnit(QuantityIndex.volume, new Unit("Cubic Inch [in³]", ((1d / 1.30795061931439d) / 46656d), 0d));
            unitManipulator._AddUnit(QuantityIndex.volume, new Unit("Litre [L]", 0.001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.volume, new Unit("Millilitre [mL]", 0.000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.volume, new Unit("Barrel", (((1d / 1.30795061931439d) / 46656d) * 9702d), 0d));
            unitManipulator._AddUnit(QuantityIndex.volume, new Unit("Gallon (Imperial)", (1d / 219.969248299088d), 0d));
            unitManipulator._AddUnit(QuantityIndex.volume, new Unit("Quart (Imperial)", ((1d / 219.969248299088d) / 4d), 0d));
            unitManipulator._AddUnit(QuantityIndex.volume, new Unit("Pint (Imperial)", ((1d / 219.969248299088d) / 8d), 0d));
            unitManipulator._AddUnit(QuantityIndex.volume, new Unit("Cup (US Customary)", 4226.75283773038d, 0d));
            unitManipulator._AddUnit(QuantityIndex.volume, new Unit("Tablespoon (US Customary)", (4226.75283773038d / 16d), 0d));
            unitManipulator._AddUnit(QuantityIndex.volume, new Unit("Teaspoon (US Customary)", (4226.75283773038d / 48d), 0d));


            // Time (11 units)
            unitManipulator._AddUnit(QuantityIndex.time, new Unit("Second [s] (S.I. Unit)", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.time, new Unit("Millisecond [ms]", 0.001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.time, new Unit("Microsecond [μs]", 0.000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.time, new Unit("Nanosecond [ns]", 000000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.time, new Unit("Minute [min]", 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.time, new Unit("Hour [h]", 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.time, new Unit("Day", 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.time, new Unit("Week", 604800d, 0d));
            unitManipulator._AddUnit(QuantityIndex.time, new Unit("Fortnight", 1209600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.time, new Unit("Year", 31536000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.time, new Unit("Year (Leap)", 31622400d, 0d));


            // Speed (15 units)
            unitManipulator._AddUnit(QuantityIndex.speed, new Unit("Metre per Second [m/s] (S.I. Unit)", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.speed, new Unit("Metre per Minute [m/min]", (1d / 60d), 0d));
            unitManipulator._AddUnit(QuantityIndex.speed, new Unit("Metre per Hour [m/h]", (1d / 3600d), 0d));
            unitManipulator._AddUnit(QuantityIndex.speed, new Unit("Kilometre per Second [km/s]", 1000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.speed, new Unit("Kilometre per Minute [km/min]", (1000d / 60d), 0d));
            unitManipulator._AddUnit(QuantityIndex.speed, new Unit("Kilometre per Hour [km/h]", (1d / 3.6d), 0d));
            unitManipulator._AddUnit(QuantityIndex.speed, new Unit("Speed of Light (c)", 299792458d, 0d));
            unitManipulator._AddUnit(QuantityIndex.speed, new Unit("Foot per Second [ft/s]", (1d / 3.280839895d), 0d));
            unitManipulator._AddUnit(QuantityIndex.speed, new Unit("Foot per Minute [ft/min]", ((1d / 3.280839895d) / 60d), 0d));
            unitManipulator._AddUnit(QuantityIndex.speed, new Unit("Foot per Hour [ft/h]", ((1d / 3.280839895d) / 3600d), 0d));
            unitManipulator._AddUnit(QuantityIndex.speed, new Unit("Mile per Second [mi/s]", ((1d / 3.280839895d) * 5280d), 0d));
            unitManipulator._AddUnit(QuantityIndex.speed, new Unit("Mile per Minute [mi/min]", ((1d / 3.280839895d) * 5280d / 60d), 0d));
            unitManipulator._AddUnit(QuantityIndex.speed, new Unit("Mile per Hour [mi/h]", ((1d / 3.280839895d) * 5280d / 3600d), 0d));
            unitManipulator._AddUnit(QuantityIndex.speed, new Unit("Mach [Ma]", 340d, 0d));
            unitManipulator._AddUnit(QuantityIndex.speed, new Unit("Knot [kn]", 1852d / 3600d, 0d));


            // Flow Rate of Area (80 units)
            // Per Second
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Metre per Second", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Kilometre per Second", 1000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Decimetre per Second", 0.01d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Centimetre per Second", 0.0001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Millimetre per Second", 0.000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Micrometre per Second", 0.000000000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Are per Second", 100d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Stremma per Second", 1000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Hectare per Second", 10000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Tetrad per Second", 4000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Hectad per Second", 100000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Myriad per Second", 10000000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Mile per Second", ((1d / 1.19599004630108d) * 3097600d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Yard per Second", (1d / 1.19599004630108d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Foot per Second", ((1d / 1.19599004630108d) / 9d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Inch per Second", ((1d / 1.19599004630108d) / 1296d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Acre per Second", ((1d / 1.19599004630108d) * 4840d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Rood per Second", ((1d / 1.19599004630108d) * 1210d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Section per Second", ((1d / 1.19599004630108d) * 3097600d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Survey Township per Second", ((1d / 1.19599004630108d) * 111513600d), 0d));
            // Per Minute
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Metre per Minute", 1d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Kilometre per Minute", 1000000d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Decimetre per Minute", 0.01d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Centimetre per Minute", 0.0001d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Millimetre per Minute", 0.000001d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Micrometre per Minute", 0.000000000001d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Are per Minute", 100d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Stremma per Minute", 1000d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Hectare per Minute", 10000d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Tetrad per Minute", 4000000d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Hectad per Minute", 100000000d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Myriad per Minute", 10000000000d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Mile per Minute", ((1d / 1.19599004630108d) * 3097600d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Yard per Minute", (1d / 1.19599004630108d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Foot per Minute", ((1d / 1.19599004630108d) / 9d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Inch per Minute", ((1d / 1.19599004630108d) / 1296d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Acre per Minute", ((1d / 1.19599004630108d) * 4840d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Rood per Minute", ((1d / 1.19599004630108d) * 1210d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Section per Minute", ((1d / 1.19599004630108d) * 3097600d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Survey Township per Minute", ((1d / 1.19599004630108d) * 111513600d) * 60d, 0d));
            // Per Hour
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Metre per Hour", 1d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Kilometre per Hour", 1000000d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Decimetre per Hour", 0.01d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Centimetre per Hour", 0.0001d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Millimetre per Hour", 0.000001d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Micrometre per Hour", 0.000000000001d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Are per Hour", 100d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Stremma per Hour", 1000d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Hectare per Hour", 10000d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Tetrad per Hour", 4000000d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Hectad per Hour", 100000000d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Myriad per Hour", 10000000000d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Mile per Hour", ((1d / 1.19599004630108d) * 3097600d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Yard per Hour", (1d / 1.19599004630108d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Foot per Hour", ((1d / 1.19599004630108d) / 9d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Inch per Hour", ((1d / 1.19599004630108d) / 1296d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Acre per Hour", ((1d / 1.19599004630108d) * 4840d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Rood per Hour", ((1d / 1.19599004630108d) * 1210d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Section per Hour", ((1d / 1.19599004630108d) * 3097600d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Survey Township per Hour", ((1d / 1.19599004630108d) * 111513600d) * 3600d, 0d));
            // Per Day
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Metre per Day", 1d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Kilometre per Day", 1000000d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Decimetre per Day", 0.01d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Centimetre per Day", 0.0001d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Millimetre per Day", 0.000001d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Micrometre per Day", 0.000000000001d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Are per Day", 100d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Stremma per Day", 1000d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Hectare per Day", 10000d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Tetrad per Day", 4000000d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Hectad per Day", 100000000d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Myriad per Day", 10000000000d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Mile per Day", ((1d / 1.19599004630108d) * 3097600d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Yard per Day", (1d / 1.19599004630108d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Foot per Day", ((1d / 1.19599004630108d) / 9d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Square Inch per Day", ((1d / 1.19599004630108d) / 1296d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Acre per Day", ((1d / 1.19599004630108d) * 4840d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Rood per Day", ((1d / 1.19599004630108d) * 1210d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Section per Day", ((1d / 1.19599004630108d) * 3097600d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowArea, new Unit("Survey Township per Day", ((1d / 1.19599004630108d) * 111513600d) * 86400d, 0d));


            // Flow Rate of Volume (60 units)
            // Per Second
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Metre per Second", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Centimetre per Second", 0.000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Millimetre per Second", 0.000000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Yard per Second", (1d / 1.30795061931439d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Foot per Second", ((1d / 1.30795061931439d) / 27d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Inch per Second", ((1d / 1.30795061931439d) / 46656d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Litre per Second", 0.001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Millilitre per Second", 0.000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Barrel per Second", (((1d / 1.30795061931439d) / 46656d) * 9702d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Gallon (Imperial) per Second", (1d / 219.969248299088d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Quart (Imperial) per Second", ((1d / 219.969248299088d) / 4d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Pint (Imperial) per Second", ((1d / 219.969248299088d) / 8d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cup (US Customary) per Second", 4226.75283773038d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Tablespoon (US Customary) per Second", (4226.75283773038d / 16d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Teaspoon (US Customary) per Second", (4226.75283773038d / 48d), 0d));
            // Per Minute
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Metre per Minute", 1d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Centimetre per Minute", 0.000001d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Millimetre per Minute", 0.000000001d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Yard per Minute", (1d / 1.30795061931439d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Foot per Minute", ((1d / 1.30795061931439d) / 27d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Inch per Minute", ((1d / 1.30795061931439d) / 46656d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Litre per Minute", 0.001d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Millilitre per Minute", 0.000001d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Barrel per Minute", (((1d / 1.30795061931439d) / 46656d) * 9702d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Gallon (Imperial) per Minute", (1d / 219.969248299088d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Quart (Imperial) per Minute", ((1d / 219.969248299088d) / 4d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Pint (Imperial) per Minute", ((1d / 219.969248299088d) / 8d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cup (US Customary) per Minute", 4226.75283773038d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Tablespoon (US Customary) per Minute", (4226.75283773038d / 16d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Teaspoon (US Customary) per Minute", (4226.75283773038d / 48d) * 60d, 0d));
            // Per Hour
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Metre per Hour", 1d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Centimetre per Hour", 0.000001d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Millimetre per Hour", 0.000000001d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Yard per Hour", (1d / 1.30795061931439d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Foot per Hour", ((1d / 1.30795061931439d) / 27d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Inch per Hour", ((1d / 1.30795061931439d) / 46656d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Litre per Hour", 0.001d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Millilitre per Hour", 0.000001d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Barrel per Hour", (((1d / 1.30795061931439d) / 46656d) * 9702d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Gallon (Imperial) per Hour", (1d / 219.969248299088d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Quart (Imperial) per Hour", ((1d / 219.969248299088d) / 4d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Pint (Imperial) per Hour", ((1d / 219.969248299088d) / 8d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cup (US Customary) per Hour", 4226.75283773038d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Tablespoon (US Customary) per Hour", (4226.75283773038d / 16d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Teaspoon (US Customary) per Hour", (4226.75283773038d / 48d) * 3600d, 0d));
            // Per Day
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Metre per Day", 1d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Centimetre per Day", 0.000001d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Millimetre per Day", 0.000000001d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Yard per Day", (1d / 1.30795061931439d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Foot per Day", ((1d / 1.30795061931439d) / 27d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cubic Inch per Day", ((1d / 1.30795061931439d) / 46656d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Litre per Day", 0.001d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Millilitre per Day", 0.000001d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Barrel per Day", (((1d / 1.30795061931439d) / 46656d) * 9702d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Gallon (Imperial) per Day", (1d / 219.969248299088d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Quart (Imperial) per Day", ((1d / 219.969248299088d) / 4d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Pint (Imperial) per Day", ((1d / 219.969248299088d) / 8d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Cup (US Customary) per Day", 4226.75283773038d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Tablespoon (US Customary) per Day", (4226.75283773038d / 16d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowVolume, new Unit("Teaspoon (US Customary) per Day", (4226.75283773038d / 48d) * 86400d, 0d));


            // Flow Rate of Mass (56 units)
            // Per Second
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Kilogram per Second", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Gram per Second", (1d / 1000d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Carat per Second", 0.0002d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Milligram per Second", (1d / 1000000d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Microgram per Second", (1d / 1000000000d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Tonne per Second", 1000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Kilotonne per Second", 1000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Pound per Second", (1d / 2.20462262184878d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Ounce per Second", ((1d / 2.20462262184878d) / 16d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Stone per Second", ((1d / 2.20462262184878d) * 14d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Ton (Short) per Second", ((1d / 2.20462262184878d) * 2000d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Ton (Long) per Second", ((1d / 2.20462262184878d) * 2240d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Kiloton (Short) per Second", ((1d / 2.20462262184878d) * 2000000d), 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Kiloton (Long) per Second", ((1d / 2.20462262184878d) * 2240000d), 0d));
            // Per Minute
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Kilogram per Minute", 1d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Gram per Minute", (1d / 1000d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Carat per Minute", 0.0002d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Milligram per Minute", (1d / 1000000d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Microgram per Minute", (1d / 1000000000d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Tonne per Minute", 1000d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Kilotonne per Minute", 1000000d * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Pound per Minute", (1d / 2.20462262184878d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Ounce per Minute", ((1d / 2.20462262184878d) / 16d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Stone per Minute", ((1d / 2.20462262184878d) * 14d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Ton (Short) per Minute", ((1d / 2.20462262184878d) * 2000d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Ton (Long) per Minute", ((1d / 2.20462262184878d) * 2240d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Kiloton (Short) per Minute", ((1d / 2.20462262184878d) * 2000000d) * 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Kiloton (Long) per Minute", ((1d / 2.20462262184878d) * 2240000d) * 60d, 0d));
            // Per Hour
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Kilogram per Hour", 1d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Gram per Hour", (1d / 1000d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Carat per Hour", 0.0002d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Milligram per Hour", (1d / 1000000d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Microgram per Hour", (1d / 1000000000d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Tonne per Hour", 1000d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Kilotonne per Hour", 1000000d * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Pound per Hour", (1d / 2.20462262184878d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Ounce per Hour", ((1d / 2.20462262184878d) / 16d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Stone per Hour", ((1d / 2.20462262184878d) * 14d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Ton (Short) per Hour", ((1d / 2.20462262184878d) * 2000d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Ton (Long) per Hour", ((1d / 2.20462262184878d) * 2240d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Kiloton (Short) per Hour", ((1d / 2.20462262184878d) * 2000000d) * 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Kiloton (Long) per Hour", ((1d / 2.20462262184878d) * 2240000d) * 3600d, 0d));
            // Per Day
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Kilogram per Day", 1d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Gram per Day", (1d / 1000d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Carat per Day", 0.0002d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Milligram per Day", (1d / 1000000d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Microgram per Day", (1d / 1000000000d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Tonne per Day", 1000d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Kilotonne per Day", 1000000d * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Pound per Day", (1d / 2.20462262184878d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Ounce per Day", ((1d / 2.20462262184878d) / 16d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Stone per Day", ((1d / 2.20462262184878d) * 14d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Ton (Short) per Day", ((1d / 2.20462262184878d) * 2000d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Ton (Long) per Day", ((1d / 2.20462262184878d) * 2240d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Kiloton (Short) per Day", ((1d / 2.20462262184878d) * 2000000d) * 86400d, 0d));
            unitManipulator._AddUnit(QuantityIndex.flowMass, new Unit("Kiloton (Long) per Day", ((1d / 2.20462262184878d) * 2240000d) * 86400d, 0d));


            // Mass (14 units)
            unitManipulator._AddUnit(QuantityIndex.mass, new Unit("Kilogram [kg] (S.I. Unit)", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.mass, new Unit("Gram [g]", (1d / 1000d), 0d));
            unitManipulator._AddUnit(QuantityIndex.mass, new Unit("Carat [ct]", 0.0002d, 0d));
            unitManipulator._AddUnit(QuantityIndex.mass, new Unit("Milligram [mg]", (1d / 1000000d), 0d));
            unitManipulator._AddUnit(QuantityIndex.mass, new Unit("Microgram [μg]", (1d / 1000000000d), 0d));
            unitManipulator._AddUnit(QuantityIndex.mass, new Unit("Tonne [t] (Metric)", 1000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.mass, new Unit("Kilotonne [kt] (Metric)", 1000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.mass, new Unit("Pound [lb]", (1d / 2.20462262184878d), 0d));
            unitManipulator._AddUnit(QuantityIndex.mass, new Unit("Ounce [oz]", ((1d / 2.20462262184878d) / 16d), 0d));
            unitManipulator._AddUnit(QuantityIndex.mass, new Unit("Stone [st.] (UK)", ((1d / 2.20462262184878d) * 14d), 0d));
            unitManipulator._AddUnit(QuantityIndex.mass, new Unit("Ton (Short)", ((1d / 2.20462262184878d) * 2000d), 0d));
            unitManipulator._AddUnit(QuantityIndex.mass, new Unit("Ton (Long)", ((1d / 2.20462262184878d) * 2240d), 0d));
            unitManipulator._AddUnit(QuantityIndex.mass, new Unit("Kiloton (Short)", ((1d / 2.20462262184878d) * 2000000d), 0d));
            unitManipulator._AddUnit(QuantityIndex.mass, new Unit("Kiloton (Long)", ((1d / 2.20462262184878d) * 2240000d), 0d));


            // Energy (9 units)
            unitManipulator._AddUnit(QuantityIndex.energy, new Unit("Joule [J] (S.I. Unit)", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.energy, new Unit("Kilojoule [kJ]", 1000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.energy, new Unit("Megajoule [MJ]", 1000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.energy, new Unit("Watt Hour [Wh]", 3600d, 0d));
            unitManipulator._AddUnit(QuantityIndex.energy, new Unit("Kilowatt Hour [kWh]", 3600000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.energy, new Unit("Megawatt Hour [MWh]", 3600000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.energy, new Unit("calorie", 4.184d, 0d));
            unitManipulator._AddUnit(QuantityIndex.energy, new Unit("Kilocalorie", 4184d, 0d));
            unitManipulator._AddUnit(QuantityIndex.energy, new Unit("British Thermal Unit (BTU)", 1055.05585262d, 0d));


            // Pressure (22 units)
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Pascal [Pa] (S.I. Unit)", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Hectopascal [hPa]", 100d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Kilopascal [kPa]", 1000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Standard Atmosphere [atm]", 101325d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Technical Atmosphere [at]", 98066.5d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Bar", 100000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Kilobar [kBar]", 100000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Megabar [MBar]", 100000000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Decibar [dBar]", 10000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Centibar", 1000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Millibar", 100d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Millimetre of Mercury [mmHg]", 133.322387415d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Centimetre of Mercury [cmHg]", 1333.22387415d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Inch of Mercury [inHg]", (133322.387415d * ((1d / 3.280839895d) / 12d)), 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Foot of Mercury [ftHg]", (133322.387415d * (1d / 3.280839895d)), 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Millimetre of Water [mmH₂O]", 9.80664857d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Centimetre of Water [cmH₂O]", 98.0664857d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Metre of Water [mH₂O]", 9806.64857d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Inch of Water [inH₂O]", (9806.64857d * ((1d / 3.280839895d) / 12d)), 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Foot of Water [ftH₂O]", (9806.64857d * (1d / 3.280839895d)), 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Pound per Square Inch [PSI]", 6894.75729d, 0d));
            unitManipulator._AddUnit(QuantityIndex.pressure, new Unit("Torr", (101325d / 760d), 0d));


            // Temperature (3 units)
            unitManipulator._AddUnit(QuantityIndex.temperature, new Unit("Kelvin [K] (S.I. Unit)", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.temperature, new Unit("Celsius [°C]", 1d, 273.15d));
            unitManipulator._AddUnit(QuantityIndex.temperature, new Unit("Fahrenheit [°F]", (5d / 9d), (459.67d * (5d / 9d))));


            // Luminance (15 units)
            unitManipulator._AddUnit(QuantityIndex.luminance, new Unit("Candela per Square Metre [cd/m²] (S.I. Unit)", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.luminance, new Unit("Candela per Square Decimetre [cd/dm²]", 100d, 0d));
            unitManipulator._AddUnit(QuantityIndex.luminance, new Unit("Candela per Square Centimetre [cd/cm²]", 10000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.luminance, new Unit("Candela per Square Millimetre [cd/mm²]", 1000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.luminance, new Unit("Candela per Square Foot [cd/ft²]", (1d / ((1d / 1.19599004630108d) / 9d)), 0d));
            unitManipulator._AddUnit(QuantityIndex.luminance, new Unit("Candela per Square Inch [cd/in²]", (1d / ((1d / 1.19599004630108d) / 1296d)), 0d));
            unitManipulator._AddUnit(QuantityIndex.luminance, new Unit("Kilocandela per Square Metre [kcd/m²]", 1000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.luminance, new Unit("Candela per Square Foot [cd/ft²]", ((1d / ((1d / 1.19599004630108d) / 9d)) * 1000d), 0d));
            unitManipulator._AddUnit(QuantityIndex.luminance, new Unit("Lambert [L]", (10000d / pi), 0d));
            unitManipulator._AddUnit(QuantityIndex.luminance, new Unit("Foot Lambert [fL]", 3.4262590996323d, 0d));
            unitManipulator._AddUnit(QuantityIndex.luminance, new Unit("Nit", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.luminance, new Unit("Stilb", 10000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.luminance, new Unit("Apostilb [asb]", (1d / pi), 0d));
            unitManipulator._AddUnit(QuantityIndex.luminance, new Unit("Skot [sk]", ((0.001d / pi)), 0d));
            unitManipulator._AddUnit(QuantityIndex.luminance, new Unit("Bril", ((0.0000001d / pi)), 0d));


            // Illuminance (15 units)
            unitManipulator._AddUnit(QuantityIndex.illuminance, new Unit("Lux [lx] (S.I. Unit)", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.illuminance, new Unit("Kilolux [klx]", 1000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.illuminance, new Unit("Megalux [Mlx]", 1000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.illuminance, new Unit("Gigalux [Glx]", 1000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.illuminance, new Unit("Millilux [mlx]", 0.001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.illuminance, new Unit("Microlux [μlx]", 0.000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.illuminance, new Unit("Nanolux [nlx]", 0.000000001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.illuminance, new Unit("Phot [ph]", 10000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.illuminance, new Unit("Milliphot [mph]", 10d, 0d));
            unitManipulator._AddUnit(QuantityIndex.illuminance, new Unit("Nox [nx]", 0.001d, 0d));
            unitManipulator._AddUnit(QuantityIndex.illuminance, new Unit("Lumen per Square Metre [lm/m²]", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.illuminance, new Unit("Lumen per Square Decimetre [lm/dm²]", 100d, 0d));
            unitManipulator._AddUnit(QuantityIndex.illuminance, new Unit("Lumen per Square Centimetre [lm/cm²]", 10000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.illuminance, new Unit("Lumen per Square Millimetre [lm/mm²]", 1000000d, 0d));
            unitManipulator._AddUnit(QuantityIndex.illuminance, new Unit("Foot-Candle [fc]", (1d / 0.092903043596611d), 0d));


            // Angle (10 units)
            unitManipulator._AddUnit(QuantityIndex.angle, new Unit("Degree [°]", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.angle, new Unit("Radian [rad]", ((1d / pi) * 180d), 0d));
            unitManipulator._AddUnit(QuantityIndex.angle, new Unit("Gradian [ᵍ]", 0.9d, 0d));
            unitManipulator._AddUnit(QuantityIndex.angle, new Unit("Second", (1d / 3600d), 0d));
            unitManipulator._AddUnit(QuantityIndex.angle, new Unit("Minute", (1d / 60d), 0d));
            unitManipulator._AddUnit(QuantityIndex.angle, new Unit("Octant", 45d, 0d));
            unitManipulator._AddUnit(QuantityIndex.angle, new Unit("Sextant", 60d, 0d));
            unitManipulator._AddUnit(QuantityIndex.angle, new Unit("Quadrant", 90d, 0d));
            unitManipulator._AddUnit(QuantityIndex.angle, new Unit("Semicircle", 180d, 0d));
            unitManipulator._AddUnit(QuantityIndex.angle, new Unit("Circle", 360d, 0d));


            // Data Size (6 units)
            unitManipulator._AddUnit(QuantityIndex.dataSize, new Unit("Byte [B]", 1d, 0d));
            unitManipulator._AddUnit(QuantityIndex.dataSize, new Unit("Kilobyte [kb]", 1024d, 0d));
            unitManipulator._AddUnit(QuantityIndex.dataSize, new Unit("Megabyte [MB]", 1048576d, 0d));
            unitManipulator._AddUnit(QuantityIndex.dataSize, new Unit("Gigabyte [GB]", 1073741824d, 0d));
            unitManipulator._AddUnit(QuantityIndex.dataSize, new Unit("Terabyte [TB]", 1099511627776d, 0d));
            unitManipulator._AddUnit(QuantityIndex.dataSize, new Unit("Petabyte [PB]", 1125899906842624d, 0d));


            return unitManipulator;
        }
    }
}