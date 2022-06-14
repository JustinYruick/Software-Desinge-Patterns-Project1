using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Aggregates
{
    //class to hold a list of heavy objects
    public class HeavyObjectList
    {
        //the acutla list
        private List<HeavyObject> hList;

        //constructor
        public HeavyObjectList()
        {
            this.hList = new List<HeavyObject>();
        }

        //adds to the list
        public void Add(HeavyObject hObject)
        {
            hList.Add(hObject);
        }

        //gets object by index
        public HeavyObject GetHeavyObject(int index)
        {
            return hList[index];
        }

        // returns lenght
        public int getLength()
        {
            return hList.Count;
        }

        //print the list by calling the heavyobject print function
        internal void Print()
        {
            for(int x = 0; x < hList.Count; x++)
            {
                hList[x].Print();
            }
        }

        //creates and iterator for the list
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
    }
}
