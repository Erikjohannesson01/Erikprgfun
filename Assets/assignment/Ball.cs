using UnityEngine;

public class Ball : ProcessingLite.GP21
{
   
    public Vector2 position; 
    public Vector2 velocity;
    public float diameter = 0.5f;

    
    public Ball(float x, float y)
    {
        position = new Vector2(x, y);

        velocity = new Vector2();
        velocity.x = Random.Range(0, 11) - 5;
        velocity.y = Random.Range(0, 11) - 5;
    }

    public void Draw()
    {
        Fill(0, 0, 255);
        Circle(position.x, position.y, 0.5f);
    }

    //Update our ball
    public void UpdatePos()
    {
        position += velocity * Time.deltaTime;

        if (position.x <= 0 || position.x >= Width)       
        {
            velocity.x = -velocity.x;
        }
        if (position.y >= Height || position.y <= 0)
        {
            velocity.y = -velocity.y;
        }

    }
}