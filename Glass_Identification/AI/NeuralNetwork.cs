using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glass_Identification.AI {
    public class NeuralNetwork {

        private Layer[] layers;
        public int NumberOfLayers { get { return layers.Length; } }


        public NeuralNetwork (List <int> neuronsPerHL) {
            int numberOfLayers = neuronsPerHL.Count + 2;

            layers = new Layer[numberOfLayers]; // create 2 layers
            
        }


        #region Feedforward
        public List<double> feedforward (List<double> inputs) {
            return null;
        }
        #endregion


        #region Training
        #endregion


        #region Testing
        #endregion
    }
}
