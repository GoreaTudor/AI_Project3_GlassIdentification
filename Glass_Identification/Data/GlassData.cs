using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glass_Identification.Data {
    public class GlassData {
        public GlassAttributes glassAttributes { get; set; }

        /// <summary>
        /// Type of glass values:
        /// <list type="number">
        ///     <item> building_windows_float_processed </item>
        ///     <item> building_windows_non_flat_processed </item>
        ///     <item> vehicle_windows_float_processed </item>
        ///     <item> vehicle_windows_non_float_processed (none in this database) </item>
        ///     <item> containers </item>
        ///     <item> tableware </item>
        ///     <item> headlamps </item>
        /// </list>
        /// </summary>
        public int TypeOfGlass { get; set; }
    }
}
