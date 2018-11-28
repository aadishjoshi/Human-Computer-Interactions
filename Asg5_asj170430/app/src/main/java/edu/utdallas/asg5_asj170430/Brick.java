package edu.utdallas.asg5_asj170430;

import android.graphics.RectF;

public class Brick {
    private  RectF rectangle;
    private boolean isVisible;

    public Brick(int row,int col, int w, int h){
        isVisible = true;
        int pad = 1;
        rectangle = new RectF(col * w + pad,
                row*h + pad,
                col*w + w - pad,
                row * h + h - pad);
    }

    public RectF getRectangle(){
        return this.rectangle;
    }

    public void setInvisible(){
        isVisible = false;
    }

    public boolean getVisibileStatus(){
        return isVisible;
    }

}
