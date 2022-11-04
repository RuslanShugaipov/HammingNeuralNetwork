using System.Collections.Generic;
using System.Linq;

namespace HammingNeuralNetwork
{
    public class Neuron
    {
        public List<double> Weights { get; }
        public List<double> Inputs { get; }
        public NeuronType NeuronType { get; }
        public double Output { get; private set; }
        public Parameters Parameters { get; private set; }

        public Neuron(NeuronType type, Parameters parameters, int index = 0)
        {
            NeuronType = type;
            Parameters = parameters;
            Weights = Parameters.patterns[index];
            switch (type)
            {
                case NeuronType.Z:
                    Weights = Weights.Aggregate(
                        new List<double>(),
                        (modifiedList, element) =>
                        {
                            element /= 2;
                            modifiedList.Add(element);
                            return modifiedList;
                        });
                    break;
                case NeuronType.A:
                    Weights = Enumerable.Range(0, Parameters.patterns.Count).Select(value => -Parameters.epsilon).ToList();
                    Weights[index] = 1;
                    break;
                default:
                    break;
            }
        }

        public double FeedForward(List<double> inputs, int index = 0)
        {
            switch (NeuronType)
            {
                case NeuronType.S:
                    Output = inputs[0];
                    break;
                case NeuronType.Z:
                    double sum = Parameters.b;
                    for (int i = 0; i < inputs.Count; ++i)
                    {
                        sum += inputs[i] * Weights[i];
                    }
                    Output = ActivationFunction(sum);
                    break;
                case NeuronType.Y:
                    Output = ActivationFunction(inputs[index]);
                    break;
                default:
                    break;
            }
            return Output;
        }

        private double ActivationFunction(double x)
        {
            switch (NeuronType)
            {
                case NeuronType.S:
                    return x;
                case NeuronType.Z:
                    if (x <= 0)
                        return 0;
                    else if (x > 0 && x <= Parameters.Un)
                        return x * Parameters.k1;
                    else
                        return Parameters.Un;
                case NeuronType.A:
                    if (x > 0)
                        return x;
                    else
                        return 0;
                case NeuronType.Y:
                    if (x > 0)
                        return 1;
                    else
                        return 0;
                default:
                    return -1;
            }
        }

        public double ReccurentProcess(List<double> inputs)
        {
            double sum = 0;
            for (int i = 0; i < inputs.Count; ++i)
            {
                sum += Weights[i] == 1 ? inputs[i] : Weights[i] * inputs[i];
            }
            Output = ActivationFunction(sum);
            return Output;
        }

        public void SetWeights(params double[] weights)
        {
            for (int i = 0; i < weights.Length; ++i)
            {
                Weights[i] = weights[i];
            }
        }
    }
}
