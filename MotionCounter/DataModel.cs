using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotionCounter
{
    public class DataModel
    {
        public string CurrentName { set; get; }
        public int CurrentValue { set; get; }
        public Dictionary<string, int>  Descript { set; get; }

    }
}
