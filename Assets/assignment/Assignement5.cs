using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignement5 : ProcessingLite.GP21
{
    Myplayer player;
    int numberOfBalls = 10;
    Ball[] balls;
    

    void Start()
    {
        
        player = new Myplayer(new Vector2(Width/2, Height/2), 1);
        

        balls = new Ball[numberOfBalls];

        for (int i = 0; i < balls.Length; i++)
        {
            balls[i] = new Ball(5, 5);
        }



    }

  
    void Update()
    {
        Background(0);
        player.Draw(balls);
        player.update();
        

        for (int i = 0; i < balls.Length; i++)
        {
            balls[i].UpdatePos();
            balls[i].Draw();
        }
    
                   
    }
}
