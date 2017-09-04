using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Task_9
{
    class MyList
    {


        public int data;
        public MyList next, pred;
        public MyList()
        {
            data = 0;
            next = null;
            pred = null;
        }
        public MyList(int d)
        {
            data = d;
            next = null;
            pred = null;
        }
        public override string ToString()
        {
            return data + " ";
        }


    }
}
