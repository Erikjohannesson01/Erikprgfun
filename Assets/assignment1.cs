using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignment1 : ProcessingLite.GP21
{
    public Vector2 Cirkel;
    public float D = 7;
    public Vector2 Rectangel;
    public float R = 6;
    public float E = 13;

    

    
    void Update()
    {

        Background(Color.black);
        
        
        LetterE();
        LetterR();
        LetterI();
        LetterK();
        Shape1();
        Shape2();
        

        

    }

    private void LetterE()
    {
        Line(4.05f, 7, 4.05f, 3);
        Line(4, 5, 6, 5);
        Line(4, 3, 6, 3);
        Line(4, 7, 6, 7);


    }

    private void LetterR()
    { 
        Line(8, 3, 8, 5);
        Line(8, 4.5f, 8.5f, 5.05f);
        Line(8.5f, 5.05f, 9, 4.5f);
    }


    private void LetterI()
    {
        Line(10, 3, 10, 4.5f);
        Line(10, 4.7f, 10, 5.05f);
    }

    private void LetterK()
    {
        Line(12, 3, 12, 7);
        Line(12, 4.5f, 13.5f, 3);
        Line(12, 4.5f, 13.5f, 6);
    }

    private void Shape1()
    {

        
        Circle(2, 2, D);
        
        Rect(9, 9, E, E);

        Fill(45, 152, 12);
        
    }

    private void Shape2()
    {
        Rect(4, 4, R, R);

        Fill(40, 12, 152);
    }


    
    
}
