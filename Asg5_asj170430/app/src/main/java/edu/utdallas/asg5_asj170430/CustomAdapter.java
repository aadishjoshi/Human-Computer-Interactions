/*******************************************************************************
 * Custom adapter class to arrange items into columns
 * ******************************************************************/
package edu.utdallas.asg5_asj170430;

import android.content.Context;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import java.util.ArrayList;


public class CustomAdapter extends ArrayAdapter<String>{

    //Adapter contructor
    CustomAdapter(Context context, String[] records){
        super(context,R.layout.custom_row,records);
    }


    //Assigning elements as per row according to column grid.
    @NonNull
    @Override
    public View getView(int position,View convertView, ViewGroup parent) {
        LayoutInflater inflater = LayoutInflater.from(getContext());
        View customView = inflater.inflate(R.layout.custom_row, parent, false);

        String frow = getItem(position);
        String[] dt= frow.split(";");
        TextView fcol = (TextView)customView.findViewById(R.id.Col1);
        fcol.setText(dt[0]);
        TextView scol = (TextView)customView.findViewById(R.id.Col2);
        scol.setText(dt[1]);
        TextView Tcol = (TextView)customView.findViewById(R.id.Col3);
        Tcol.setText(dt[2]);
        return customView;
    }
}
