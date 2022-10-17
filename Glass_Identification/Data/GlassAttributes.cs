using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glass_Identification.Data {
    public class GlassAttributes {
        public int ID { get; set; }                         // 1 - Id
        public double RefractiveIndex { get; set; }         // 2 - RI
        public double SodiumPercentage { get; set; }        // 3 - Na %
        public double MagnesiumPercentage { get; set; }     // 4 - Mg %
        public double AluminumPercentage { get; set; }      // 5 - Al %
        public double SiliconPercentage { get; set; }       // 6 - Si &
        public double PotassiumPercentage { get; set; }     // 7 - K %
        public double CalciumPercentage { get; set; }       // 8 - Ca %
        public double BariumPercentage { get; set; }        // 9 - Ba %
        public double IronPercentage { get; set; }          // 10 - Fe %
    }
}
