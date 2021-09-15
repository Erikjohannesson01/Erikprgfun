using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment2 : ProcessingLite.GP21

    
{

    float spaceBetweenLines = 0.5f;
    float xstart = 1;
    float ystart = 20;
    float check = 3;
    // Start is called before the first frame update
    void Start()
    {
        Background(0, 0 ,0);
        Line(xstart, 0, 0, ystart);
        Stroke(255, 128, 128);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        

        for (int i = 0; i < ystart; i++)
        {
            Line(xstart, 0, 0, ystart);
            xstart += 1;
            ystart -= 1;
            if (xstart % check == 1)
            {
                check += 3;
                Stroke(255, 128, 128);
            }
            else
            {
                Stroke(128, 128, 255);
            }


        }
    }
}
