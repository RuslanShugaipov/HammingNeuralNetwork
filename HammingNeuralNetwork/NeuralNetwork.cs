using System;
using System.Linq;
using System.Collections.Generic;

namespace HammingNeuralNetwork
{
    public class NeuralNetwork
    {
        public Topology Topology { get; }
        public List<Layer> Layers { get; }
        public Parameters Parameters { get; }

        public NeuralNetwork(Topology topology, Parameters parameters)
        {
            Topology = topology;
            Parameters = parameters;
            Layers = new List<Layer>();

            CreateInputLayer();
            CreateHiddenLayers();
            CreateOutputLayer();
        }

        public int Predict(List<double> inputSignals)
        {
            SendSignalToInputNeurons(inputSignals);
            FeedForward();

            return Layers.Last().Neurons.IndexOf(Layers.Last().Neurons.Find(output => output.Output == 1));
        }

        private void FeedForward()
        {
            for (int i = 1; i < Layers.Count; ++i)
            {
                var layer = Layers[i];
                var previousLayerSignals = Layers[i - 1].GetSignals();
                List<double> previousSignals = new List<double>();
                List<double> currentSignals = previousLayerSignals;
                if (i == 2)
                {
                    while (!CompareLists(previousSignals, currentSignals))
                    {
                        previousSignals = new List<double>(currentSignals);
                        for (int j = 0; j < layer.Neurons.Count; ++j)
                        {
                            currentSignals[j] = Math.Round(layer.Neurons[j].ReccurentProcess(previousSignals), 4);
                        }
                    }
                    for(int k = 0; k < 2; ++k)
                    {
                        previousSignals = new List<double>(currentSignals);
                        for (int j = 0; j < layer.Neurons.Count; ++j)
                        {
                            currentSignals[j] = Math.Round(layer.Neurons[j].ReccurentProcess(previousSignals), 3);
                        }
                    }
                    continue;
                }
                foreach (var neuron in layer.Neurons)
                {
                    neuron.FeedForward(previousLayerSignals, layer.Neurons.IndexOf(neuron));
                }
            }
        }

        private bool CompareLists(List<double> list1, List<double> list2)
        {
            if (list1.Count == 0 || list2.Count == 0)
                return false;
            bool isEqual = true;
            for (int i = 0; i < list1.Count; ++i)
            {
                isEqual = Math.Round(list1[i], 3).Equals(Math.Round(list2[i], 3));
                if (isEqual == false)
                    break;
            }
            return isEqual;
        }

        private void SendSignalToInputNeurons(List<double> inputSignals)
        {
            for (int i = 0; i < inputSignals.Count; ++i)
            {
                var signal = new List<double>() { inputSignals[i] };
                var neuron = Layers[0].Neurons[i];

                neuron.FeedForward(signal);
            }
        }

        private void CreateOutputLayer()
        {
            var outputNeurons = new List<Neuron>();
            var lastLayer = Layers.Last();
            for (int i = 0; i < Topology.OutputCount; ++i)
            {
                var neuron = new Neuron(NeuronType.Y, Parameters);
                outputNeurons.Add(neuron);
            }
            var outputLayer = new Layer(outputNeurons);
            Layers.Add(outputLayer);
        }

        private void CreateHiddenLayers()
        {
            for (int j = 0; j < Topology.HiddenLayers.Count; ++j)
            {
                var hiddenNeurons = new List<Neuron>();
                var lastLayer = Layers.Last();
                for (int i = 0; i < Topology.HiddenLayers[j]; ++i)
                {
                    NeuronType type = j == 0 ? NeuronType.Z : NeuronType.A;
                    var neuron = type == NeuronType.Z ? new Neuron(type, Parameters, i) : new Neuron(type, Parameters, i);
                    hiddenNeurons.Add(neuron);
                }
                var outputLayer = new Layer(hiddenNeurons);
                Layers.Add(outputLayer);
            }
        }

        private void CreateInputLayer()
        {
            var inputNeurons = new List<Neuron>();
            for (int i = 0; i < Topology.InputCount; ++i)
            {
                var neuron = new Neuron(NeuronType.S, Parameters);
                inputNeurons.Add(neuron);
            }
            var inputLayer = new Layer(inputNeurons);
            Layers.Add(inputLayer);
        }
    }
}
