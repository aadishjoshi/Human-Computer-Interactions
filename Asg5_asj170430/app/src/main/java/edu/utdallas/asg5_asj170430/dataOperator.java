package edu.utdallas.asg5_asj170430;

import android.content.Context;
import android.widget.ArrayAdapter;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by aadis on 04-11-2018.
 */

/***************************************************************************
 * Intermediate layer between dataHandler and MainActivity
 * *************************************************************************/

public class dataOperator {
    dataHandler dl = new dataHandler();
    //To check data empty
    public String checkEmpty(GetterSetter data){return dl.isDataEmpty(data);}

    //to store file data
    public boolean doFileSave(Context e, GetterSetter data){return dl.saveFileData(e,data);}

    //To populdate data
    public List<ScoreCompare> doDataPopulate(Context e){return dl.dataPopulate(e);}

}
