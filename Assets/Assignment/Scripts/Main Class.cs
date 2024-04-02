using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClass : MonoBehaviour
{

    //this is to keep the mouse direction as a variable
    Vector3 mouseDirection;
    //To access the Collider of the objects
    protected Collider2D hitBox;
    //for the teleport of the opject to its rigt location
    public GameObject snappingPoint;


    // Start is called before the first frame update
    protected virtual void Start()
    {
        hitBox = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        //checks if both the hitbox is off and the mouse is up then set the new location for the object
        if (hitBox.enabled == false && Input.GetMouseButtonUp(0) ) transform.position = snappingPoint.transform.position;
    }










    //To capture the mouse position on the scene
    private Vector3 MousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    //set the vector for the mousedirection to handle where to move the object
    private void OnMouseDown()
    {
        mouseDirection = gameObject.transform.position - MousePosition();
    }


    //to update the onjects position where the mouse is going
    private void OnMouseDrag()
    {
        transform.position = MousePosition() + mouseDirection;
    }

    //if it enter the cooking pot turn off the collider
    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
            hitBox.enabled = false;
    }



}
