using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishesBehaviour : MainClass
{
   // override done to avoid the hitbox turning off (need it for the ingredient to interact with it)
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        base.hitBox.enabled = true;
        transform.position = snappingPoint.transform.position;

    }
    //to make sure that it teleports when the hitbox is still active (reference the update on main class to understand)
    public override void Update()
    {
        if (hitBox.enabled == true && Input.GetMouseButtonUp(0)) transform.position = snappingPoint.transform.position;

    }

}
