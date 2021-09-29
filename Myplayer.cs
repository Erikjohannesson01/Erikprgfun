using System;

public class Myplayer
{
	public Myplayer()
	{

        public Vector2 cirkel;
        float diameter = 2;
        public Vector2 acceleration = new Vector2(0, 0);
        float fart = 2;
        float snabbare = 0.2f;
        float langsammare = 0.2f;


        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            cirkel.x += -fart * Time.deltaTime;
            acceleration.x += -snabbare * Time.deltaTime;
        }

        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            cirkel.x += fart * Time.deltaTime;
            acceleration.x += snabbare * Time.deltaTime;
        }

        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            cirkel.y += -fart * Time.deltaTime;
            acceleration.y += -snabbare * Time.deltaTime;
        }

        else if (Input.GetAxisRaw("Vertical") > 0)
        {
            cirkel.y += fart * Time.deltaTime;
            acceleration.y += snabbare * Time.deltaTime;
        }

        else
        {
            if (acceleration.x >= 0)
            {
                acceleration.x -= langsammare * Time.deltaTime;
            }

            if (acceleration.x <= 0)
            {
                acceleration.x += langsammare * Time.deltaTime;
            }

            if (Mathf.Abs(acceleration.x) <= 0.001f)
            {
                acceleration.x = 0;
            }

            if (acceleration.y >= 0)
            {
                acceleration.y -= langsammare * Time.deltaTime;
            }
            if (acceleration.y <= 0)
            {
                acceleration.y += langsammare * Time.deltaTime;
            }
        }

        if (Mathf.Abs(acceleration.y) <= 0.001f)
        {
            acceleration.y = 0;
        }

        if (acceleration.magnitude > 0.2f)
        {
            acceleration = acceleration.normalized * 0.2f;
        }

        cirkel.x += acceleration.x;
        cirkel.y += acceleration.y;

        Circle(cirkel.x, cirkel.y, diameter);
        Fill(0, 255, 0);

        irkel.x = Width / 2;
        cirkel.y = Height / 2;

    }
}
