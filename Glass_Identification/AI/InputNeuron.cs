using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glass_Identification.AI {
    class InputNeuron : Neuron {

        public InputNeuron () { }

        public override double f (double x) { 
            return x; 
        }

        public override double f_derivative (double x) { 
            return x; 
        }
    }
}
