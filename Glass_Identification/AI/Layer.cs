using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glass_Identification.AI {
    class Layer {
        public Neuron[] neurons;

        public int NumberOfNeurons { get { return neurons.Length; } }

        public Layer() { }

        public double[] feedThroughLayer (double[] inputs) {
            double[] layerOutput = new double[NumberOfNeurons];

            for (int n = 0; n < NumberOfNeurons; n ++) {
                layerOutput[n] = neurons[n].propagateForward (inputs);
            }

            return layerOutput;
        }
    }
}
