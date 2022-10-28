using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glass_Identification.AI {
    public class NeuralNetwork {

        private Layer[] layers;
        public int NumberOfLayers { get { return layers.Length; } }

        public double epoch_error_sum { get; set; }

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
                for (int n = 0; n < layers[l].NumberOfNeurons; n++) {
                    layers[l].neurons[n] = new HiddenNeuron ();
                }
            }

            layers[numberOfLayers - 1].neurons = new OutputNeuron[Global.NumberOfOutputs];
            for (int n = 0; n < layers[numberOfLayers - 1].NumberOfNeurons; n++) {
                layers[numberOfLayers - 1].neurons[n] = new OutputNeuron ();
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
        public void backpropagation (double[] inputs, double[] target, double learningRate) {
            /// Feedforward ///
            double[] output = feedforward (inputs);


            /// Mean Square Error ///
            double sum_error = 0;
            for (int i = 0; i < Global.NumberOfOutputs; i ++) {
                double val = target[i] - output[i];
                sum_error += val * val;
            }
            double mse = sum_error / (2.0 * Global.NumberOfOutputs);
            epoch_error_sum += mse;


            /// Calculate deltas ///
            Layer OL = layers[NumberOfLayers - 1];
            for (int n = 0; n < OL.NumberOfNeurons; n ++) {
                Neuron neuron = OL.neurons[n];
                neuron.delta = (neuron.output - target[n]) * neuron.f_derivative (neuron.globalInput);
            }

            for (int l = NumberOfLayers - 2; l >= 0; l --) {
                Layer curr_layer = layers[l];
                Layer next_layer = layers[l + 1];

                for (int n = 0; n < curr_layer.NumberOfNeurons; n ++) {
                    Neuron neuron = curr_layer.neurons[n];

                    double sum = 0.0;
                    foreach (Neuron next_neuron in next_layer.neurons) {
                        sum += next_neuron.delta * next_neuron.weights[n];
                    }

                    neuron.delta = sum * neuron.f_derivative (neuron.output);
                }
            }


            /// Change weights ///
            for (int l = 1; l < NumberOfLayers; l ++) {
                Layer layer = layers[l];

                for (int n = 0; n < layer.NumberOfNeurons; n ++) {
                    Neuron neuron = layer.neurons[n];

                    for (int w = 0; w < neuron.NumberOfWeights; w ++) {
                        double d_w = learningRate * layers[l - 1].neurons[w].output * neuron.delta;
                        neuron.weights[w] += d_w;
                    }
                }
            }
        }
        #endregion


        #region Testing
        #endregion
    }
}
