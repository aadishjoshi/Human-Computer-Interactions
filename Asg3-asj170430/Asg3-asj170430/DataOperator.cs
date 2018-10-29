using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg3_asj170430
{
    class DataOperator
    {
        DataHandler data = new DataHandler();

        //interlayer between frontend and data manupulation layer
        public GetterSetterClass evaluateFile(String fname)
        {
            return data.evaluateData(fname);
        }

        public bool writeFile(String fname, GetterSetterClass dataInstance)
        {
            return data.writeData(fname, dataInstance);
        }
    }
}
