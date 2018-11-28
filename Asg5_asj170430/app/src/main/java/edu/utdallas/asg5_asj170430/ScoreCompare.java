/**********************************************************************************************
 * Score compare class .
 * Also a default class for ArrayList for custom comparison purpose.
 * *********************************************************************************************/
package edu.utdallas.asg5_asj170430;

import android.util.Log;

public class ScoreCompare implements Comparable{
    private String playerName;
    private Integer score;
    private String date;

    //ScoreCompare constructor
    public ScoreCompare(String playerName, int score, String date){
        this.playerName = playerName;
        this.score = score;
        this.date = date;
    }

    //to check equality
    public boolean equals(ScoreCompare player){
        if(this.playerName != player.playerName){
            return false;
        }
        if(this.score == player.score){
            return false;
        }
        if(this.date != player.date){
            return false;
        }
        return true;
    }

    //to return data in string format
    public String toString(){
        return(playerName +";"+score+";"+date);
    }


    //to make ScoreCompare object for ArrayList
    public static ScoreCompare getData(String findDataString){
        String [] data = findDataString.split("\t");
        ScoreCompare result = new ScoreCompare(data[0],Integer.parseInt(data[1]), data[2]);
        return result;
    }

    //Overrided method for implements Comparable.
    //Custom comparisons.
    @Override
    public int compareTo(Object p) {
//        return Integer.compare(this.score, ((ScoreCompare)p).score);
        if(this.score > ((ScoreCompare)p).score){
            return -1;
        }
        if(this.score < ((ScoreCompare)p).score){
            return -1;
        }
        if(this.date.compareTo((((ScoreCompare) p).date)) > 0)
            return -1;
        if(this.date.compareTo((((ScoreCompare) p).date)) < 0)
            return 1;

        return 0;
    }
}
