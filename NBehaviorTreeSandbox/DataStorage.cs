using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBehaviorTreeSandbox
{
    public class DataStorage
    {
        public DataStorage()
        {
            Counter = 0;
        }
        public int Counter { get; set; }
        private string _someField;
        public string SomeField
        {
            get
            {
                Counter++;
                return _someField;
            }
            set { _someField = value; }
        }

    }
}
