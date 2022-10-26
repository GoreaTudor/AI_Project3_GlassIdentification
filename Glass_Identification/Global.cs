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
        private static List<GlassDataNormalized> trainingData = new List<GlassDataNormalized> ();
        public static List<GlassDataNormalized> TrainingData {
            get {
                return trainingData;
            }
        }

        private static List<GlassDataNormalized> testingData = new List<GlassDataNormalized> ();
        public static List<GlassDataNormalized> TestingData {
            get {
                return testingData;
            }
        }


        ///// OTHER /////
        public static readonly int NumberOfInputs = 9;
        public static readonly int NumberOfOutputs = 7;

        private static Random rnd = new Random();
        public static Random random { get { return rnd; } }
    }
}
