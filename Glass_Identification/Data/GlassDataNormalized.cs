using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glass_Identification.Data {
    public class GlassDataNormalized {
        public int ID { get; set; }                         // 1 - Id (doesn't count as input, but looks nice on table)

        public double RefractiveIndex { get; set; }         // 2 - RI
        public double SodiumPercentage { get; set; }        // 3 - Na %
        public double MagnesiumPercentage { get; set; }     // 4 - Mg %
        public double AluminumPercentage { get; set; }      // 5 - Al %
        public double SiliconPercentage { get; set; }       // 6 - Si &
        public double PotassiumPercentage { get; set; }     // 7 - K %
        public double CalciumPercentage { get; set; }       // 8 - Ca %
        public double BariumPercentage { get; set; }        // 9 - Ba %
        public double IronPercentage { get; set; }          // 10 - Fe %

        /// <summary> building flat </summary>
        public double Type_1 { get; set; }
        /// <summary> building non-flat </summary>
        public double Type_2 { get; set; }
        /// <summary> vehicle flat </summary>
        public double Type_3 { get; set; }
        /// <summary> vehicle non-flat </summary>
        public double Type_4 { get; set; }
        /// <summary> containers </summary>
        public double Type_5 { get; set; }
        /// <summary> tableware </summary>
        public double Type_6 { get; set; }
        /// <summary> headlamps </summary>
        public double Type_7 { get; set; }


        public GlassDataNormalized (GlassDataRaw raw) {
            this.ID = raw.ID;

            this.RefractiveIndex        = (raw.RefractiveIndex      - DataMinMax.min_RI) / (DataMinMax.max_RI - DataMinMax.min_RI);  // 2 - RI
            this.SodiumPercentage       = (raw.SodiumPercentage     - DataMinMax.min_Na) / (DataMinMax.max_Na - DataMinMax.min_Na);  // 3 - Na
            this.MagnesiumPercentage    = (raw.MagnesiumPercentage  - DataMinMax.min_Mg) / (DataMinMax.max_Mg - DataMinMax.min_Mg);  // 4 - Mg
            this.AluminumPercentage     = (raw.AluminumPercentage   - DataMinMax.min_Al) / (DataMinMax.max_Al - DataMinMax.min_Al);  // 5 - Al
            this.SiliconPercentage      = (raw.SiliconPercentage    - DataMinMax.min_Si) / (DataMinMax.max_Si - DataMinMax.min_Si);  // 6 - Si
            this.PotassiumPercentage    = (raw.PotassiumPercentage  - DataMinMax.min_K)  / (DataMinMax.max_K  - DataMinMax.min_K);   // 7 - K
            this.CalciumPercentage      = (raw.CalciumPercentage    - DataMinMax.min_Ca) / (DataMinMax.max_Ca - DataMinMax.min_Ca);  // 8 - Ca
            this.BariumPercentage       = (raw.BariumPercentage     - DataMinMax.min_Ba) / (DataMinMax.max_Ba - DataMinMax.min_Ba);  // 9 - Ba
            this.IronPercentage         = (raw.IronPercentage       - DataMinMax.min_Fe) / (DataMinMax.max_Fe - DataMinMax.min_Fe);  // 10 - Fe

            this.Type_1 = (raw.TypeOfGlass == 1) ? 1 : 0;
            this.Type_2 = (raw.TypeOfGlass == 2) ? 1 : 0;
            this.Type_3 = (raw.TypeOfGlass == 3) ? 1 : 0;
            this.Type_4 = (raw.TypeOfGlass == 4) ? 1 : 0;
            this.Type_5 = (raw.TypeOfGlass == 5) ? 1 : 0;
            this.Type_6 = (raw.TypeOfGlass == 6) ? 1 : 0;
            this.Type_7 = (raw.TypeOfGlass == 7) ? 1 : 0;
        }


        public List <double> getInputs () {
            List <double> inputs = new List <double> ();
            inputs.Add (RefractiveIndex);
            inputs.Add (SodiumPercentage);
            inputs.Add (MagnesiumPercentage);
            inputs.Add (AluminumPercentage);
            inputs.Add (SiliconPercentage);
            inputs.Add (PotassiumPercentage);
            inputs.Add (CalciumPercentage);
            inputs.Add (BariumPercentage);
            inputs.Add (IronPercentage);

            return inputs;
        }

        public List <double> getOutputs() {
            List <double> outputs = new List <double> ();
            outputs.Add (Type_1);
            outputs.Add (Type_2);
            outputs.Add (Type_3);
            outputs.Add (Type_4);
            outputs.Add (Type_5);
            outputs.Add (Type_6);
            outputs.Add (Type_7);

            return outputs;
        }


        public override string ToString () {
            return "GlassData: {" +
                $"Id={ID}, " +
                $"RI={RefractiveIndex}, " +
                $"Na={SodiumPercentage}, " +
                $"Mg={MagnesiumPercentage}, " +
                $"Al={AluminumPercentage}, " +
                $"Si={SiliconPercentage}, " +
                $"K={PotassiumPercentage}, " +
                $"Ca={CalciumPercentage}, " +
                $"Ba={BariumPercentage}, " +
                $"Fe={IronPercentage}, " +
                $"Type_1={Type_1}, " +
                $"Type_2={Type_2}, " +
                $"Type_3={Type_3}, " +
                $"Type_4={Type_4}, " +
                $"Type_5={Type_5}, " +
                $"Type_6={Type_6}, " +
                $"Type_7={Type_7}" +
                "}";
        }
    }
}
