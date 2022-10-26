using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glass_Identification.AI {
    class HiddenNeuron : Neuron {

        public HiddenNeuron () { }

        public override double f (double x) { 
            return NeuralNetworkUtilities.TanH (x); 
        }

        public override double f_derivative (double x) { 
            return NeuralNetworkUtilities.TanH_derivative (x); 
        }
    }
}
