using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToppingBehaviour : MainClass
{
    //reference to the sprite renderer component
    SpriteRenderer sp2;

    //This functions uses start from the parent and add the sprite renderer / color the color change function
    protected override void Start()
    {
        base.Start();
        sp2 = GetComponent<SpriteRenderer>();
        RandomColorGreen();
    }
    //this changes the green value of the sprite
    void RandomColorGreen()
    {
        sp2.color = new Color(1f, Random.Range(0, 1f), 1f);
    }

}
