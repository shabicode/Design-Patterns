using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCS.Observer
{
    public  interface IObserver
    {
        void Update(object obj);
    }
}
