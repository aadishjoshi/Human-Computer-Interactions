package edu.utdallas.asg5_asj170430;

import android.graphics.RectF;

import java.util.Random;
/**
 * Created by aadis on 27-11-2018.
 */

public class Ball {

    RectF rectangle;
    float xSpeed;
    float ySpeed;
    float ballWidth = 10;
    float ballHeight = 10;

    public Ball(int screenX, int screenY){
        xSpeed = 200;
        ySpeed = -400;

        rectangle = new RectF();
    }

    public RectF getRectangle(){
        return rectangle;
    }

    public void oppYDirection(){
        ySpeed = -ySpeed;
    }

    public void oppXDirection(){
        xSpeed = -xSpeed;
    }

    public void update(long fps){
        rectangle.left = rectangle.left + (xSpeed / fps);
        rectangle.top = rectangle.top + (ySpeed / fps);
        rectangle.right = rectangle.left + ballWidth;
        rectangle.bottom = rectangle.top - ballHeight;
    }

    public void defaultRandomSpeed(){
        Random r = new Random();
        int ans = r.nextInt(2);
        if(ans == 0){
            oppXDirection();
        }
    }

    public void avoidObstacleY(float y){
        rectangle.bottom = y;
        rectangle.top = y - ballHeight;
    }

    public void avoidObstacleX(float x){
        rectangle.left = x;
        rectangle.right = x+ballWidth;
    }

    public void reset(int x,int y){
        rectangle.left = x/2;
        rectangle.top = y - 20;
        rectangle.right = x/2 + ballWidth;
        rectangle.bottom = y - 20 - ballHeight;
    }

}
