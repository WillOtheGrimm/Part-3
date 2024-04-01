using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClass : MonoBehaviour
{


    Vector3 mouseDirection;
    Collider2D collider2D;
    public GameObject ingredientSnap;
   


    // Start is called before the first frame update
    void Start()
    {
        collider2D = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
      
        if (collider2D.enabled == false && Input.GetMouseButtonUp(0) ) transform.position = ingredientSnap.transform.position;
     
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


    private void OnTriggerEnter2D(Collider2D collision)
    {
            collider2D.enabled = false;
        Debug.Log("triggered");
    }








}
