using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass_Identification.Data;

namespace Glass_Identification {
    public class Global {

        ///// RAW DATA /////
        private static List <GlassDataRaw> rawData = new List <GlassDataRaw> ();
        public static List<GlassDataRaw> RawData {
            get {
                return rawData;
            }
        }


        ///// NORMALIZED DATA /////
        private static List<GlassDataNormalized> normalizedData = new List<GlassDataNormalized> ();
        public static List<GlassDataNormalized> NormalizedData {
            get {
                return normalizedData;
            }
        }


        ///// OTHER /////
    }
}
