using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooker : MonoBehaviour
{
    //Get access to all the object that uses the Interface class
    private Interface[] interfaces;
    //reference to the transform of the object given
    public Transform cookDestination;

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
       //when pressing the cook button make sure that ingredient are present and start corroutine for animation
       StartCoroutine(CookingRoutine());

    }



    IEnumerator CookingRoutine()
    {
        //This is to wait that all animations are done before clearing the objects
        foreach (var item in interfaces)
        {
            yield return StartCoroutine(item.CookingAnimationRoutine(cookDestination));

        }




      //if any ingredient is present allow to cook (clear the object on board)
        foreach (var component in interfaces)
        {
            component.ClearItem();
        }


        //this adds to the recipe counter
        RecipeCounter.AddRecipe();

    }

}
