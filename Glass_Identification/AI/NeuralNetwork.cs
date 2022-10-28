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
        private void calculateStepError (double[] output, double[] target) {
            /// Mean Square Error ///
            double sum_error = 0;

            for (int i = 0; i < Global.NumberOfOutputs; i++) {
                double val = target[i] - output[i];

                sum_error += val * val;
            }

            double mse = sum_error / (2.0 * Global.NumberOfOutputs);
            epoch_error_sum += mse;
        }

        public void backpropagation (double[] inputs, double[] target, double learningRate) {
            /// Feedforward ///
            double[] output = feedforward (inputs);


            /// Mean Square Error ///
            calculateStepError (output, target);


            ///// OL /////
            Layer OL = layers[layers.Length - 1];
            Layer last_HL = layers[layers.Length - 2];

            // for each neuron in OL
            for (int n = 0; n < OL.NumberOfNeurons; n ++) { 
                Neuron neuron = OL.neurons[n];

                // calculate neuron delta
                neuron.delta = (neuron.output - target[n])  *  (neuron.output * (1 - neuron.output)); // sigmoid derivative

                // for each weight
                for (int w = 0; w < neuron.weights.Length; w ++) { 

                    // calculate weight change
                    double delta_weight = learningRate  *  last_HL.neurons[w].output  *  neuron.delta; 

                    // add the change to the weight
                    neuron.weights[w] -= delta_weight; 
                }
            }


            ///// HL /////
            
            // for each hidden layer
            for (int l = layers.Length - 2; l >= 1; l --) {
                Layer curr_layer = layers[l];
                
                // for each neuron in the current layer
                for (int n = 0; n < curr_layer.NumberOfNeurons; n ++) {
                    Neuron neuron = curr_layer.neurons[n];

                    // calculate the sum of all deltas from the next layer, multiplied by their corresponding weight
                    double delta_sum = 0.0;
                    foreach (Neuron n_neuron in layers[l + 1].neurons) {
                        delta_sum += n_neuron.delta  *  n_neuron.weights[n];
                    }

                    // calculate neuron delta
                    neuron.delta = delta_sum  *  (1  -  neuron.output * neuron.output); // TanH derivative

                    // for each weight
                    for (int w = 0; w < neuron.weights.Length; w ++) {

                        // calculate weight change
                        double delta_weight = learningRate  *  layers[l - 1].neurons[w].output  *  neuron.delta;

                        // add the change to the weight
                        neuron.weights[w] -= delta_weight;
                    }
                }
            }
        }
        #endregion


        #region Testing
        #endregion
    }
}
