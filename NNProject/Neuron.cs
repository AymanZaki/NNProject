﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNProject
{
    class Neuron
    {
        public List<double> weights;
        bool bias;
        /// <summary>
        /// The constructor recieves number of inputs and boolean indicating existence of the bias & initializes the weights with random numbers
        /// </summary>
        /// <param name="numberOfInputs"></NumberOfInputFeatures>
        /// <param name="b"></Bias>
        public Neuron(int numberOfInputs, bool b)
        {
            bias = b;
            weights = new List<double>();
            for (int i = 0; i < numberOfInputs; i++)
                weights.Add(GetRandomNumber(0, 1));
            if (bias)
                weights.Add(GetRandomNumber(0, 1));
        }

        /// <summary>
        /// The fireSigmoid function applies the sigmoid function on the input features 
        /// </summary>
        /// <param name="features"></InputFeatures>
        /// <returns></WeightsXInputFeatures>
        public double fireSigmoid(List<double> features)
        {
            if (bias)
              features.Add(1);

            double value = 0;

            for (int i = 0; i < features.Count; i++)
                value += features[i] * weights[i];
            return 1.0/(1.0+Math.Exp(-value));
        }

        double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}