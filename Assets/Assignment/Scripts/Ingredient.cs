using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : Interface
{
  
    //
    public override bool CanCook()
    {
        return itemInstance != null;
    }
}
