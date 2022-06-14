using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    class StackingStrategy_Pyramid : StackingStrategy
    {
        //calcuates the score for the stack of boxes
        public float EvaluateStack(HeavyObjectList list)
        {
            //finds to position of the widet object and calutaes a score vales of position
            float widesttObject = 0.0f;
            float position = 0.0f;
            float temp = 0.0f;
            float score = 0.0f; 
            HeavyObject cObject;
            for (Iterator i = list.CreateIterator(); !i.IsDone(); i.Next())
            {
                cObject = i.CurrentItem();
                temp = cObject.Width;
                if (temp > widesttObject)
                {
                    widesttObject = temp;
                    position = i.Index();
                }
            }
            score = (position + 1) / list.getLength();


            return score;
        }
    }
}
