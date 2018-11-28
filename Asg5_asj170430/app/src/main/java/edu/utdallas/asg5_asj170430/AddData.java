/**********************************************************************************************
 * AcdData Activity .
 * Activity for data addition.
 * *********************************************************************************************/

package edu.utdallas.asg5_asj170430;

import android.content.Intent;
import android.icu.util.Calendar;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import java.util.Date;

public class AddData extends AppCompatActivity {

    static GetterSetter data = new GetterSetter();
    dataOperator operator = new dataOperator();



    /**********************************************************************************************
     * OnCreate method.
     * Intent for new activity start.
     * Handles data.
     * *********************************************************************************************/
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_data);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        final EditText playerName = (EditText)findViewById(R.id.playerNameText);
        final EditText score = (EditText)findViewById(R.id.scoreText);
        final EditText date = (EditText) findViewById(R.id.dateText);

        Date currentDate = new Date(System.currentTimeMillis());
        date.setText(currentDate.toString());
        Button addData = findViewById(R.id.addDataBtn);

        addData.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                data.playerName = playerName.getText().toString();
                data.score = score.getText().toString();
                data.date = date.getText().toString();

                String err = operator.checkEmpty(data);
                if(err.equals("")){
                    boolean saved = operator.doFileSave(getApplicationContext(),data);
                    if(saved){
                        Toast.makeText(getApplicationContext(),"Saved",Toast.LENGTH_SHORT).show();
                    }
                }else{
                    Toast.makeText(getApplicationContext(),"Err",Toast.LENGTH_SHORT).show();
                }
            }
        });


        Button returnActivity = findViewById(R.id.returnActivity);

        returnActivity.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(AddData.this, MainActivity.class);
                startActivity(i);
            }
        });



    }

}
