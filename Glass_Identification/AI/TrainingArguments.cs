using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass_Identification.Data;

namespace Glass_Identification.AI {
    public class TrainingArguments {
        public double epsilon { get; set; }
        public double learningRate { get; set; }
        public int numberOfEpochs { get; set; }
        public List <GlassDataNormalized> trainingDataset { get; set; }
    }
}
