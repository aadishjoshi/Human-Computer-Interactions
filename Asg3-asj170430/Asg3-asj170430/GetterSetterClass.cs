using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg3_asj170430
{
    class GetterSetterClass
    {
        public int totalRecords { get; set; }
        public int backSpaceCount { get; set; }
        public TimeSpan timeTotal { get; set; }
        public TimeSpan entryTimeMin { get; set; }
        public TimeSpan entryTimeMax { get; set; }
        public TimeSpan entryTimeAvg { get; set; }
        public TimeSpan betweenTimeMax { get; set; }
        public TimeSpan betweenTimeMin { get; set; }
        public TimeSpan betweenTimeAvg { get; set; }
    }
}
