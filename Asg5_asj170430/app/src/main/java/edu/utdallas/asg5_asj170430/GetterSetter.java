/**********************************************************************************************
 * GetterSetter class for instanciation.
 * *********************************************************************************************/

package edu.utdallas.asg5_asj170430;

import java.util.Set;

/**
 * Created by aadis on 04-11-2018.
 */

public class GetterSetter {
    String playerName;
    String score;
    String date;

    public String getDate() {
        return date;
    }

    public void setDate(String date) {
        this.date = date;
    }

    public String getPlayerName() {
        return playerName;
    }

    public void setPlayerName(String playerName) {
        this.playerName = playerName;
    }

    public String getScore() {
        return score;
    }

    public void setScore(String score) {
        this.score = score;
    }
}
