using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    class StackingStrategy_Topple : StackingStrategy
    {
        //calcuates the score for the stack of boxes
        public float EvaluateStack(HeavyObjectList list)
        {
            //findes how heavy the top box is to see if it is topheavy and will tople
            float heaviestObject = 0.0f;
            float position = 0.0f;
            float temp = 0.0f;
            float score = 0.0f;
            HeavyObject cObject;
            for (Iterator i = list.CreateIterator(); !i.IsDone(); i.Next())
            {
                cObject = i.CurrentItem();
                temp = cObject.Mass;
                if (temp > heaviestObject)
                {
                    heaviestObject = temp;
                    position = i.Index();
                }
            }
            score =  (list.getLength() / (position + 1));


            return score;
        }
    }
}
