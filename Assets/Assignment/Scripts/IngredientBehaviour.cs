using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientBehaviour : MainClass
{
    //reference to the sprite renderer component

    SpriteRenderer sp;



    //This functions uses start from the parent and add the sprite renderer / color the color change function
    protected override void Start()
    {
        base.Start();
        sp = GetComponent<SpriteRenderer>();
        RandomColorRed();
    }


    //Function to change the red value of the sprite renderer
    void RandomColorRed()
    {
        sp.color = new Color(Random.Range(0, 1f), 1f, 1f);
    }



}
