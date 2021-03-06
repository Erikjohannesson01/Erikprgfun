using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment4 : ProcessingLite.GP21
{
        public Vector2 cirkel;
        public Vector2 cirkel2;
        float diameter = 2;
        public Vector2 acceleration = new Vector2(0,0);
        float fart = 2;
        float snabbare = 0.2f;
        float langsammare = 0.2f;
    

   
    void Start()
    {
        cirkel.x = Width / 2;
        cirkel.y = Height / 2;
        cirkel2.x = Width / 4;
        cirkel2.y = Height / 2;
        
    }


    void Update()
    {
        Background(0);


            if (Input.GetKey(KeyCode.A))
            {
                cirkel.x += -fart * Time.deltaTime;
                acceleration.x += -snabbare * Time.deltaTime;

            }

            else if (Input.GetKey(KeyCode.D))
            {
                cirkel.x += fart * Time.deltaTime;
                acceleration.x += snabbare * Time.deltaTime;
            }
        
            if (Input.GetKey(KeyCode.S))
            {
                cirkel.y += -fart * Time.deltaTime;
                acceleration.y += -snabbare * Time.deltaTime;
            }

            else if (Input.GetKey(KeyCode.W))
            {
                cirkel.y += fart * Time.deltaTime;
                acceleration.y += snabbare * Time.deltaTime;
            }

            else
            {
                if(acceleration.x >= 0)
            { 
                acceleration.x -= langsammare * Time.deltaTime;
            }

            if(acceleration.x <= 0)
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

            cirkel2.x += acceleration.x;
            cirkel2.y += acceleration.y;

            Circle(cirkel.x, cirkel.y, diameter);
            Fill(0, 255, 0);
            Circle(cirkel2.x, cirkel2.y, diameter);
            Fill(0, 0, 255);

            Debug.Log("1: " + cirkel);
            Debug.Log("2: " + cirkel2);


    }
}
