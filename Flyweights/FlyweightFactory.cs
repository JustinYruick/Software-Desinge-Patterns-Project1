using Assi1.Strategies;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Assi1.Flyweights
{
    //flywight class to store stacking stategys
    class FlyweightFactory
    {

        //stores the flywights
        private Dictionary<string, StackingStrategy> flyWeights;

        //constructor
        public FlyweightFactory()
        {
            flyWeights = new Dictionary<string, StackingStrategy>();
        }

        //returns flyweight base of given key value
        public StackingStrategy GetFlyweight(string key, StackingStrategy strategy)
        {
            if(flyWeights.ContainsKey(key))
            {
                return flyWeights[key];
            }
            else
            {
                flyWeights[key] = strategy;
                return strategy;
            }
        }

    }
}

