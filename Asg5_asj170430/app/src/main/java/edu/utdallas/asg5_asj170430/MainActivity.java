/*******************************************************************************************************************
* This assignment is to write the part of a game that tracks high scores.
 * The fields of interest are the name of the user, the score, and the date/time that the user got that score
 * Assignment 05
* Written By:- Aadish Joshi
 ** NetID: asj170430
 * Date: November 04, 2018
* **************************************************************************************************************************/
package edu.utdallas.asg5_asj170430;

import android.content.Intent;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.util.Log;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListAdapter;
import android.widget.ListView;

import java.io.Console;
import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {


    dataOperator operator = new dataOperator();

    /***************************************************************************
    * On Create activity for the main class. Sets custom adapter.
     * Facility to add data
     * Intent activity to redirect to new activity (AddData activity)
    * *************************************************************************/
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        Button addActivity = findViewById(R.id.AddActivity);

        addActivity.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(MainActivity.this, MainActivityBreakout.class);
                startActivity(i);
            }
        });

        List<ScoreCompare> result = operator.doDataPopulate(this);
        ListView aadishView = (ListView)findViewById(R.id.aadishListView);
        Integer size = (result == null)?0 : result.size();

        if(size > 0){

            String [] arr = new String[size];
            int i =0;

            for(ScoreCompare p:result){

                p.compareTo(p);
                arr[i] = p.toString();
                i++;
            }

//            for(ScoreCompare p:result){
//                arr[i] = p.toString();
//                i++;
//            }

            ListAdapter adapter = new CustomAdapter(this,arr);
            aadishView.setAdapter(adapter);
        }
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}
