using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Aggregates
{
    //iterator class to iterate troiugh heavy object list
    public class Iterator
    {
        int pointer;
        HeavyObjectList heavyObjectList;

        //constructor 
        public Iterator(HeavyObjectList heavyObjectList)
        {
            this.heavyObjectList = heavyObjectList;
        }

        //points to first object in list
        public HeavyObject First()
        {
            return this.heavyObjectList.GetHeavyObject(0);
        }


        //goes to next position
        public void Next()
        {
            pointer++;
        }

        //goes to previouse postion
        public void Prev()
        {
            pointer--;
        }

        //is the list done
        public bool IsDone()
        {
            return pointer >= this.heavyObjectList.getLength();
        }

        //returns curret item
        public HeavyObject CurrentItem()
        {
            return this.heavyObjectList.GetHeavyObject(pointer);
        }

        //returns the index
        public int Index()
        {
            return this.pointer;
        }
    }
}
