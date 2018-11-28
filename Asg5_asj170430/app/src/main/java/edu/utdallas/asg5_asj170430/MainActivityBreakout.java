package edu.utdallas.asg5_asj170430;


import android.content.Context;
import android.content.Intent;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Point;
import android.graphics.RectF;
import android.os.Bundle;
import android.os.Handler;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.util.Log;
import android.view.Display;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Toast;


public class MainActivityBreakout extends AppCompatActivity {

    supportViewClass supportView;
    static GetterSetter data = new GetterSetter();
    dataOperator operator = new dataOperator();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        supportView = new supportViewClass(this);
        setContentView(supportView);

    }

    @Override
    protected void onResume() {
        super.onResume();
        supportView.resume();
    }

    @Override
    protected void onPause() {
        super.onPause();
        supportView.pause();
    }

    /*-------------------------------------------------------------*/

    public class supportViewClass extends SurfaceView implements  Runnable {
        Thread playThread = null;
        SurfaceHolder playHolder;
        volatile boolean isPlaying;
        boolean isPaused = true;
        Canvas canvas;
        Paint paint;
        long fps;
        boolean saved = false;
        private long currentTimeFrame;

        int screenX;
        int screenY;

        Arm arm;
        Ball ball;

        Brick[] bricks = new Brick[200];
        int noBricks = 0;

        int score = 0;
        int lives = 3;

        public supportViewClass(Context context){
            super(context);
            playHolder = getHolder();
            paint = new Paint();

            Display myDisplay = getWindowManager().getDefaultDisplay();

            Point getSize = new Point();
            myDisplay.getSize(getSize);

            screenX = getSize.x;
            screenY = getSize.y;

            arm = new Arm(screenX,screenY);
            ball = new Ball(screenX,screenY);

            BricksAndReset();
        }

        public void BricksAndReset(){
            ball.reset(screenX,screenY);
            int brickWidth = screenX / 8;
            int brickHeight = screenY / 10;

            noBricks = 0;

            for(int col = 0; col <8;col++){
                for(int row = 0; row<3;row++){
                    bricks[noBricks] = new Brick(row,col,brickWidth,brickHeight);
                    noBricks++;
                }
            }

            if(lives == 0){
                data.playerName = "aadish";
                data.score = ""+score;
                data.date = "Nov 19, 2018";

                saved = operator.doFileSave(getApplicationContext(),data);


//                score = 0;
//                lives = 3;
            }
        }

        @Override
        public void run() {

            while(isPlaying){

                long begingFTime = System.currentTimeMillis();

                if(!isPaused){
                    update();
                }
                draw();
                currentTimeFrame = System.currentTimeMillis() - begingFTime;
                if(currentTimeFrame >= 1){
                    fps = 1000/currentTimeFrame;
                }
            }

        }

        public void draw(){
            if(playHolder.getSurface().isValid()){
                canvas = playHolder.lockCanvas();
                canvas.drawColor(Color.argb(255,26,128,182));
                paint.setColor(Color.argb(255,255,255,255));
                canvas.drawRect(arm.getArm(),paint);
                canvas.drawRect(ball.getRectangle(),paint);
                paint.setColor(Color.argb(255,249,129,0));

                for(int i =0; i< noBricks; i++){
                    if(bricks[i].getVisibileStatus()){
                        canvas.drawRect(bricks[i].getRectangle(), paint);
                    }
                }

                paint.setColor(Color.argb(255,255,255,255));


                paint.setTextSize(40);
                canvas.drawText("Score: "+ score + " Lives:" + lives, 10,50,paint);

                if(score == noBricks *10){
                    paint.setTextSize(90);
                    canvas.drawColor(Color.TRANSPARENT);
                    canvas.drawText("You Won!",10,screenY/2,paint);
                }

                if(lives <= 0){
                    if(saved){
                        canvas.drawText("data saved!",screenX/2,screenY/2,paint);
                    }
                    paint.setTextSize(90);
                    canvas.drawColor(Color.TRANSPARENT);
                    canvas.drawText("You Lost!",10,screenY/2,paint);
                }


                playHolder.unlockCanvasAndPost(canvas);
            }
        }

        public void update(){

            arm.update(fps);
            ball.update(fps);

            for(int i=0;i <noBricks; i++){
                if(bricks[i].getVisibileStatus()){
                    if(RectF.intersects(bricks[i].getRectangle(), ball.getRectangle())){
                        bricks[i].setInvisible();
                        ball.oppYDirection();
                        score = score +10;
                    }
                }
            }

            if(RectF.intersects(arm.getArm(),ball.getRectangle())){
                ball.defaultRandomSpeed();
                ball.oppYDirection();
                ball.avoidObstacleY(arm.getArm().top - 2);
            }

            if(ball.getRectangle().bottom > screenY){
                ball.oppYDirection();
                ball.avoidObstacleY(screenY - 2);

                lives --;

                if(lives == 0){
                    isPaused = true;
                    BricksAndReset();
                }
            }

            if(ball.getRectangle().top < 0){
                ball.oppYDirection();
                ball.avoidObstacleY(12);
            }

            if(ball.getRectangle().left < 0){
                ball.oppXDirection();
                ball.avoidObstacleX(2);

            }

            if(ball.getRectangle().right > screenX - 10){
                ball.oppXDirection();
                ball.avoidObstacleX(screenX - 22);
            }

            if(score == noBricks *10){
                isPaused = true;
                BricksAndReset();
            }
        }

        public void pause(){
            isPlaying = false;
            try{
                playThread.join();
            }catch(Exception e){
                Log.e("Error:","e");
            }
        }

        public void resume(){
            isPlaying = true;
            playThread = new Thread(this);
            playThread.start();
        }



        @Override
        public boolean onTouchEvent(MotionEvent event) {
            switch(event.getAction() & MotionEvent.ACTION_MASK){
                case MotionEvent.ACTION_DOWN:
                    isPaused  = false;

                    if(event.getX() > screenX / 2){
                        arm.setRotateState(arm.isRight);
                    }else{
                        arm.setRotateState(arm.isLeft);
                    }
                    break;
                case MotionEvent.ACTION_UP:
                    arm.setRotateState(arm.isStopped);
                    break;
            }
            return true;
        }
    }














}
