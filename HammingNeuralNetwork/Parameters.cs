using System.Collections.Generic;

namespace HammingNeuralNetwork
{
    public class Parameters
    {
        public List<List<double>> patterns { get; set; }
        public double b => patterns?[0].Count / 2.0 ?? 0;
        public double k1 { get; set; }
        public double Un => 1.0 / this?.k1 ?? 0;
        public double epsilon => 1.0 / patterns?.Count ?? 0;

        public Parameters(List<List<double>> patterns, double k1)
        {
            this.patterns = patterns;
            this.k1 = k1;
        }
    }
}
