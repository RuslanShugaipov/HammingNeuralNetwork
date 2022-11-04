//using System.Collections.Generic;

//namespace HammingNeuralNetwork
//{
//    public class Layer
//    {
//        public List<Neuron> Neurons { get; }
//        public int Count => Neurons?.Count ?? 0;

//        public Layer(List<Neuron> neurons, NeuronType type = NeuronType.S)
//        {
//            Neurons = neurons;
//        }

//        public List<double> GetSignals()
//        {
//            var result = new List<double>();
//            foreach(var neuron in Neurons)
//            {
//                result.Add(neuron.Output);
//            }
//            return result;
//        }
//    }
//}

using System.Collections.Generic;

namespace HammingNeuralNetwork
{
    public class Layer
    {
        public List<Neuron> Neurons { get; }
        public int Count => Neurons?.Count ?? 0;

        public Layer(List<Neuron> neurons, NeuronType type = NeuronType.S)
        {
            Neurons = neurons;
        }

        public List<double> GetSignals()
        {
            var result = new List<double>();
            foreach (var neuron in Neurons)
            {
                result.Add(neuron.Output);
            }
            return result;
        }
    }
}
