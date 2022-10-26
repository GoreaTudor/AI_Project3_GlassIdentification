using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glass_Identification.AI {
    abstract class Neuron {
        public int layerID { get; set; }
        public int neuronID { get; set; }

        public double[] weights { get; set; }
        public int NumberOfWeights { 
            get { 
                return weights.Length; 
            } 

            set {
                weights = new double[value];
                double upper = 1.0;
                double lower = -1.0;
                for (int i = 0; i < weights.Length; i++) {
                    weights[i] = Global.random.NextDouble () * (upper - lower) + lower;
                }
            } 
        }

        public double output { get; set; }
        public double delta { get; set; }

        public double propagateForward (double[] inputs) {
            double globalInput = 0.0;

            for (int w = 0; w < NumberOfWeights; w++) {
                globalInput += weights[w] * inputs[w];
            }

            this.output = f (globalInput);
            return this.output;
        }

        public abstract double f (double x);
        public abstract double f_derivative (double x);
    }
}
