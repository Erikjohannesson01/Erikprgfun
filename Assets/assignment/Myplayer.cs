using UnityEngine;

public class Myplayer : ProcessingLite.GP21
{
    public Vector2 pos = new Vector2(0, 0);
    public Vector2 velocity = new Vector2(0, 0);
    public float diameter = 0;
    public Vector2 acc = new Vector2(0, 0);
    public Vector2 fart = new Vector2(0, 0);



    public Myplayer(Vector2 pos, float diameter)
    {
        this.pos = pos;
        this.diameter = diameter;
    }

    public void Draw(Ball[] balls)
    {
        Fill(255, 0, 0);
        Circle(pos.x, pos.y, diameter);
        for (int i = 0; i < balls.Length; i++)
        {
            CircleCollision(pos.x, pos.y, diameter, balls[i].position.x, balls[i].position.y, balls[i].diameter);
        }
    }

    public void update()
    {

        Vector2 direction = new Vector2(0, 0);
        direction.x = pos.x + Input.GetAxisRaw("Horizontal");
        direction.y = pos.y + Input.GetAxisRaw("Vertical");
        move(direction);

        if (acc == Vector2.zero)
        {
            velocity.x = Mathf.Lerp(velocity.x, 0, 0.01f);
            velocity.y = Mathf.Lerp(velocity.y, 0, 0.01f);
        }

        velocity += acc * Time.deltaTime;

        velocity = Vector2.ClampMagnitude(velocity, 10f);

        pos += velocity * Time.deltaTime;






    }

    public bool CircleCollision(float x1, float y1, float size1, float x2, float y2, float size2)
    {
        float maxDistance = size1 / 2 + size2 / 2;

        if (Mathf.Abs(x1 - x2) > maxDistance || Mathf.Abs(y1 - y2) > maxDistance)
        {
            return false;
        }

        else if (Vector2.Distance(new Vector2(x1, y1), new Vector2(x2, y2)) > maxDistance)
        {
            return false;
        }

        else
        {
            TextSize(50);
            Fill(120, 210, 180);
            Text("You lose", Width/2, Height/2);
            Time.timeScale = 0 * Time.deltaTime;
            return true;
        }

    }
        public void move(Vector2 dir)
        {

            acc = dir - pos;

            acc = acc.normalized;

            acc *= 20f;

        }
}