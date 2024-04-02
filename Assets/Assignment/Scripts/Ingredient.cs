using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : Interface
{
  
    //Only allows to cook when an item is spawned
    public override bool CanCook()
    {
        return itemInstance != null;
    }

  



}
