/**********************************************************************************************
 * Data Handler Class .
 * Main class for data handling and data operations.
 * *********************************************************************************************/
package edu.utdallas.asg5_asj170430;

import android.content.Context;
import android.widget.ArrayAdapter;
import android.widget.ListAdapter;
import android.widget.Toast;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by aadis on 04-11-2018.
 */

public class dataHandler {

    //to check if data is empty
    public String isDataEmpty(GetterSetter data){
        String err = "";
        if(data.playerName == ""){
            err += "Player Name invalid";
        }
        if(data.score == ""){
            err += "Player Score invalid";
        }
        if(data.date == ""){
            err += "Invalid date";
        }
        return err;
    }


    /**********************************************************************************************
     * File save functionality
     * *********************************************************************************************/
    public boolean saveFileData(Context context, GetterSetter data){
        String name = data.playerName;
        String score = data.score;
        String date = data.date;
        String write_data = name + "\t" + score + "\t" + date + "\n";

        try{
            OutputStreamWriter writer = new OutputStreamWriter(context.openFileOutput("CS6326Asg5.txt", Context.MODE_APPEND));
            writer.write(write_data);
            writer.close();
            return true;
        }catch (Exception e){
            return false;
        }
    }



    /**********************************************************************************************
     * Data populate functionality.
     * *********************************************************************************************/
    public List<ScoreCompare> dataPopulate(Context context){

        List<ScoreCompare> input = new ArrayList<>();
        try {
            InputStream file = context.openFileInput("CS6326Asg5.txt");

            if(file != null){
                BufferedReader reader = new BufferedReader(new InputStreamReader(file));
                String record = "";
                while((record = reader.readLine())!=null){
                    input.add(ScoreCompare.getData(record));
                }
            }
            Toast.makeText(context,"Your Data",Toast.LENGTH_SHORT).show();
        }catch(Exception e){

        }
        return input;
    }

}
