using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glass_Identification.AI {
    class OutputNeuron : Neuron {

        public OutputNeuron () { }

        public override double f (double x) { 
            return NeuralNetworkUtilities.Sigmoid (x); 
        }

        public override double f_derivative (double x) { 
            return NeuralNetworkUtilities.Sigmoid_derivative (x); 
        }
    }
}
