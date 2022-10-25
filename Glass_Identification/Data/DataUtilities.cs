using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Glass_Identification.Data {
    class DataUtilities {
        public static List <GlassDataNormalized> NormalizeData (List <GlassDataRaw> rawData) {
            FindMinMax (rawData);

            List <GlassDataNormalized> normalizedData = new List <GlassDataNormalized> ();
            foreach (GlassDataRaw item in rawData) {
                normalizedData.Add (new GlassDataNormalized(item));
            }

            return normalizedData;
        }

        private static void FindMinMax (List <GlassDataRaw> rawData) {
            double min, max;

            /// 2 - RI ///
            min = max = rawData[0].RefractiveIndex;
            foreach (GlassDataRaw item in rawData) {
                min = (item.RefractiveIndex < min) ? item.RefractiveIndex : min;
                max = (item.RefractiveIndex > max) ? item.RefractiveIndex : max;
            }
            DataMinMax.min_RI = min;
            DataMinMax.max_RI = max;


            /// 3 - Na ///
            min = max = rawData[0].SodiumPercentage;
            foreach (GlassDataRaw item in rawData) {
                min = (item.SodiumPercentage < min) ? item.SodiumPercentage : min;
                max = (item.SodiumPercentage > max) ? item.SodiumPercentage : max;
            }
            DataMinMax.min_Na = min;
            DataMinMax.max_Na = max;


            /// 4 - Mg ///
            min = max = rawData[0].MagnesiumPercentage;
            foreach (GlassDataRaw item in rawData) {
                min = (item.MagnesiumPercentage < min) ? item.MagnesiumPercentage : min;
                max = (item.MagnesiumPercentage > max) ? item.MagnesiumPercentage : max;
            }
            DataMinMax.min_Mg = min;
            DataMinMax.max_Mg = max;


            /// 5 - Al ///
            min = max = rawData[0].AluminumPercentage;
            foreach (GlassDataRaw item in rawData) {
                min = (item.AluminumPercentage < min) ? item.AluminumPercentage : min;
                max = (item.AluminumPercentage > max) ? item.AluminumPercentage : max;
            }
            DataMinMax.min_Al = min;
            DataMinMax.max_Al = max;


            /// 6 - Si ///
            min = max = rawData[0].SiliconPercentage;
            foreach (GlassDataRaw item in rawData) {
                min = (item.SiliconPercentage < min) ? item.SiliconPercentage : min;
                max = (item.SiliconPercentage > max) ? item.SiliconPercentage : max;
            }
            DataMinMax.min_Si = min;
            DataMinMax.max_Si = max;


            /// 7 - K ///
            min = max = rawData[0].PotassiumPercentage;
            foreach (GlassDataRaw item in rawData) {
                min = (item.PotassiumPercentage < min) ? item.PotassiumPercentage : min;
                max = (item.PotassiumPercentage > max) ? item.PotassiumPercentage : max;
            }
            DataMinMax.min_K = min;
            DataMinMax.max_K = max;


            /// 8 - Ca ///
            min = max = rawData[0].CalciumPercentage;
            foreach (GlassDataRaw item in rawData) {
                min = (item.CalciumPercentage < min) ? item.CalciumPercentage : min;
                max = (item.CalciumPercentage > max) ? item.CalciumPercentage : max;
            }
            DataMinMax.min_Ca = min;
            DataMinMax.max_Ca = max;


            /// 9 - Ba ///
            min = max = rawData[0].BariumPercentage;
            foreach (GlassDataRaw item in rawData) {
                min = (item.BariumPercentage < min) ? item.BariumPercentage : min;
                max = (item.BariumPercentage > max) ? item.BariumPercentage : max;
            }
            DataMinMax.min_Ba = min;
            DataMinMax.max_Ba = max;


            /// 10 - Fe ///
            min = max = rawData[0].IronPercentage;
            foreach (GlassDataRaw item in rawData) {
                min = (item.IronPercentage < min) ? item.IronPercentage : min;
                max = (item.IronPercentage > max) ? item.IronPercentage : max;
            }
            DataMinMax.min_Fe = min;
            DataMinMax.max_Fe = max;
        }


        /// <summary>
        /// This algorithm is good for mixing the data entries to reduce the probability of grouped data.
        /// </summary>
        /// <param name="data">the list that is going to be shuffled</param>
        public static void ShuffleData (List <GlassDataNormalized> data) {
            Random rnd = new Random ();

            for (int i = 0; i < data.Count - 1; i++) {
                int index = rnd.Next (i + 1, data.Count);
                GlassDataNormalized temp = data[i];
                data[i] = data[index];
                data[index] = temp;
            }
        }

        /// <summary>
        /// Splits the dataset in two different datasets. 70% Training, 30% Testing
        /// </summary>
        /// <param name="data">the list that is going to be split 70% - 30%</param>
        public static void SplitData (List <GlassDataNormalized> data) {
            int step = 7 * data.Count / 10;

            for (int i = 0; i < data.Count; i++) {
                if (i < step) {
                    Global.TrainingData.Add (data[i]);
                } else {
                    Global.TestingData.Add (data[i]);
                }
            }
        }  
    }


    public delegate double MyValue <T> (double v, T item);
}
