using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    class StackingStrategy_BottomWeight : StackingStrategy
    {
        //calcuates the score for the stack of boxes
        public float EvaluateStack(HeavyObjectList list)
        {
            float objectScore = 0.0f;
            float temp = 0.0f;
            float score = 0.0f;
            HeavyObject cObject;
            //itterates trought the list and calculates score based off how heavy the item is and how close it is to the bottom of the list 
            for (Iterator i = list.CreateIterator(); !i.IsDone(); i.Next())
            {
                cObject = i.CurrentItem();
                temp = cObject.Mass;
                objectScore = i.CurrentItem().Mass * i.Index();
                score += objectScore;
            }
            score = score / 100;
            return score;
        }
    }
}
