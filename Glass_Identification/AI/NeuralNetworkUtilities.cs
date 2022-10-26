using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glass_Identification.AI {
    class NeuralNetworkUtilities {
        public static double Sigmoid (double x) {
            return 1.0 / (1.0 + Math.Exp(-x));
        }

        public static double Sigmoid_derivative (double x) {
            double s = Sigmoid (x);
            return (s * (1 - s));
        }


        public static double TanH (double x) {
            double e = Math.Exp (x);
            double _e = Math.Exp (-x);

            return (e - _e) / (e + _e);
        }

        public static double TanH_derivative (double x) {
            double t = TanH (x);
            return 1.0 - t * t;
        }
    }
}
