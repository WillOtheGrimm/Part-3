using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishesBehaviour : MainClass
{


    public override void OnTriggerEnter2D(Collider2D collision)
    {
        //base.GetComponent<Collider2D>().enabled = true;
        base.hitBox.enabled = true;
        transform.position = snappingPoint.transform.position;

    }

    public override void Update()
    {
        if (hitBox.enabled == true && Input.GetMouseButtonUp(0)) transform.position = snappingPoint.transform.position;

       // if(isCooking == true ) Destroy(gameObject);
    }

}
