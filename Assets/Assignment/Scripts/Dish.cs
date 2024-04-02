using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish : Interface
{

    //This makes it so that the dish doesnt move in the animation
    public override IEnumerator CookingAnimationRoutine(Transform destination)
    {
        yield return null;
    }
}
