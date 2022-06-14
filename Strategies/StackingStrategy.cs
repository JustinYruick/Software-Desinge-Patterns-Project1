using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    //strategy interface
    interface StackingStrategy
    {
        //calculates the score for the stack of boxes
        float EvaluateStack(HeavyObjectList list);
        
    }
}
