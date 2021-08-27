using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forex.Model
{
    /*public class MyEnumerator
    {*/
       /* int nIndex;
        MyCollection collection;
        public MyEnumerator(MyCollection coll)
        {
            collection = coll;
            nIndex = -1;
        }

        public bool MoveNext()
        {
            nIndex++;
            return (nIndex < collection.items.Length);
        }

        public int Current => collection.items[nIndex];
    }*/
    public class Mid
    {
       /* public MyEnumerator GetEnumerator()
   {  
      return new MyEnumerator(this);
    }*/
    public string o { get; set; }
        public string h { get; set; }
        public string l { get; set; }
        public string c { get; set; }
    }

    public class Candle
    {
        public bool complete { get; set; }
        public int volume { get; set; }
        public string time { get; set; }
        public Mid mid { get; set; }
    }

    public class Root
    {
        public string instrument { get; set; }
        public string granularity { get; set; }
        public List<Candle> candles { get; set; }
    }

    class Order
    {
        public int units { get; set; }
        public string instrument { get; set; }
        public string timeInForce { get; set; }
        public string type { get; set; }
        public string positionFill { get; set; }
    }

    class TradeInfo
    {
        public Order order { get; set; }
    }
}

