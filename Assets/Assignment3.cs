using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment3 : ProcessingLite.GP21
{
    public Vector2 circlepos;
    public Vector2 direktion;
    public float diameter = 0.5f;
    

    

    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
        Background(0, 0, 0);
        
        if (Input.GetMouseButton(0))
        {
            Line(circlepos.x, circlepos.y, MouseX, MouseY);
        }

        if (Input.GetMouseButtonUp(0))
        {
            direktion = new Vector2(MouseX - circlepos.x, MouseY - circlepos.y);
            Debug.Log(direktion);

            if (circlepos.x > Width)
            {
                direktion *= -1;
            }

            if (circlepos.y > Height)
            {
                direktion *= -1;
            }
        }


        if (Input.GetMouseButtonDown(0))
        {
            circlepos.x = MouseX;
            circlepos.y = MouseY;
        }

        if (!Input.GetMouseButton(0))
        {
            if (circlepos.x <= 0 || circlepos.x >= Width)
            {
                direktion.x *= -1;
            }

            if (circlepos.y >= Height || circlepos.y <= 0)
            {
                direktion.y *= -1;
            }
        }

        circlepos += direktion * Time.deltaTime;
        Circle(circlepos.x, circlepos.y, diameter);
    }
}
