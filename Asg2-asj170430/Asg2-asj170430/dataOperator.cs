using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg2_asj170430
{
    class dataOperator
    {
        //layer above the data Handler 
        dataHandler dl = new dataHandler();
        public string checkEmpty(GetterSetterClass data) { return dl.isDataEmpty(data);}
        public string checkValid(GetterSetterClass data) { return dl.isDataValid(data); }
        public bool doFileSave(GetterSetterClass data) { return dl.saveFileData(data); }
        public bool doFileModify(GetterSetterClass data) { return dl.modifyFileData(data); }
        public bool doFileDelete(GetterSetterClass data) { return dl.deleteFileData(data); }
        public List<listSavedData> doUpdateList() { return dl.updateListRecord(); }
        public GetterSetterClass doDataPopulate(string name) { return dl.dataPopulate(name); }

    }
}
