using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glass_Identification.AI {
    public class NeuralNetwork {

        private Layer[] layers;
        public int NumberOfLayers { get { return layers.Length; } }

        /// <summary>
        /// Generates a neural network
        /// </summary>
        /// <param name="neuronsPerHL"> the <b>length of the list</b> represents the <i>nr of hidden layers</i>, 
        /// and <b>each entry</b> represents <i>nr of hidden neurons in that layer</i> </param>
        public NeuralNetwork (List <int> neuronsPerHL) {
            int numberOfLayers = neuronsPerHL.Count + 2;

            // create layers
            layers = new Layer[numberOfLayers];
            for (int l = 0; l < layers.Length; l++) {
                layers[l] = new Layer ();
            }


            // create neurons per layer
            layers[0].neurons = new InputNeuron[Global.NumberOfInputs];
            for (int n = 0; n < layers[0].NumberOfNeurons; n++) {
                layers[0].neurons[n] = new InputNeuron ();
            }

            for (int l = 1; l <= numberOfLayers - 2; l++) {
                layers[l].neurons = new HiddenNeuron[neuronsPerHL[l - 1]];
                for (int n = 0; n < layers[0].NumberOfNeurons; n++) {
                    layers[0].neurons[n] = new HiddenNeuron ();
                }
            }

            layers[numberOfLayers - 1].neurons = new OutputNeuron[Global.NumberOfOutputs];
            for (int n = 0; n < layers[0].NumberOfNeurons; n++) {
                layers[0].neurons[n] = new OutputNeuron ();
            }


            // set nr of weights per neuron
            for (int l = 1; l < numberOfLayers; l++) { // IL has no weights
                Layer curr_layer = layers[l];
                Layer prev_layer = layers[l - 1];

                for (int n = 0; n < curr_layer.NumberOfNeurons; n ++) {
                    Neuron neuron = curr_layer.neurons[n];
                    neuron.NumberOfWeights = prev_layer.NumberOfNeurons;
                }
            }
        }


        #region Feedforward
        public double[] feedforward (double[] inputs) {
            double[] layerOutput = inputs;

            for (int l = 1; l < NumberOfLayers; l ++) {
                layerOutput = layers[l].feedThroughLayer (layerOutput);
            }

            return layerOutput;
        }
        #endregion


        #region Training
        #endregion


        #region Testing
        #endregion
    }
}
