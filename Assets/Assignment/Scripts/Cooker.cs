using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooker : MonoBehaviour
{
    //Get access to all the object that uses the Interface class
    private Interface[] interfaces;
    public GameObject lerpDestination;

    void Start()
    {
    //gets access to all the interfaces in the scene to reference them in the cook funtion
        interfaces = FindObjectsOfType<Interface>();
    }

    

    //This function will clear the item on board all at once
    public void Cook ()
    {
        //Checks if all component are here to allow cooking
        bool isAbleToCook = false;
        foreach (var item in interfaces)
        {
            if (item.CanCook())
            {
                isAbleToCook = true;    
                break;
            }

        }
        //if no component is present then dont cook
        if ( isAbleToCook == false)
        {
            return;
        }
       //if any ingredient is present allow to cook (clear the object on board)
        foreach (var component in interfaces)
        {
            component.ClearItems();
        }


        //this adds to the recipe counter
        RecipeCounter.AddRecipe();


       // StartCoroutine(CookingRoutine());

        


    }



   /* IEnumerator CookingRoutine()
    {
     


        
    }*/

}
