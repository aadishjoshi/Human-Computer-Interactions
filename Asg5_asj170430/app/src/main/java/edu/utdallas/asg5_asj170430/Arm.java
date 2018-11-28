package edu.utdallas.asg5_asj170430;
import android.graphics.RectF;
/**
 * Created by aadis on 27-11-2018.
 */

public class Arm {
    private RectF ArmRect;
    private float length;
    private float height;

    private float x;
    private float y;

    private float armSpeed;

    public final int isStopped = 0;
    public final int isLeft = 1;
    public final int isRight = 2;

    private int isArmRotating = 0;

    public Arm(int screenX,int screenY){
        length = 130;
        height = 20;
        x = screenX / 2;
        y = screenY - 20;
        ArmRect = new RectF(x,y,x+length,y+height);
        armSpeed = 350;
    }

    public RectF getArm(){
        return ArmRect;
    }

    public void setRotateState(int state){
        isArmRotating = state;
    }

    public void update(long fps){
        if(isArmRotating == isLeft){
            x = x - armSpeed / fps;
        }

        if(isArmRotating == isRight){
            x = x + armSpeed /fps;
        }

        ArmRect.left = x;
        ArmRect.right = x + length;


    }

}
