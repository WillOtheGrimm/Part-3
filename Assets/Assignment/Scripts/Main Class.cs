using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClass : MonoBehaviour
{


    Vector3 mouseDirection;
    protected Collider2D hitBox;
    public GameObject snappingPoint;


    // Start is called before the first frame update
    void Start()
    {
        hitBox = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    public virtual void Update()
    {


        if (hitBox.enabled == false && Input.GetMouseButtonUp(0) ) transform.position = snappingPoint.transform.position;

        

     
    }




   

    public virtual void Snapping ()
    {
        if (hitBox.enabled == false && Input.GetMouseButtonUp(0)) transform.position = snappingPoint.transform.position;

    }









    //To capture the mouse position
    private Vector3 MousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    
    private void OnMouseDown()
    {
        mouseDirection = gameObject.transform.position - MousePosition();
    }



    private void OnMouseDrag()
    {
        transform.position = MousePosition() + mouseDirection;
    }


    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
            hitBox.enabled = false;
            Debug.Log("triggered");
    }



}
