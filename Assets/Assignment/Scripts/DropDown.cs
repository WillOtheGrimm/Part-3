using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{
    public GameObject ingredientSnap;
    public GameObject[] ingredientPrefab = new GameObject[3];
    bool hasIngredient = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void IngredientSelection(int IngredientIndex)

    {
        if (hasIngredient == false && IngredientIndex != 0)
        {
            Instantiate(ingredientPrefab[IngredientIndex]);
            //hasIngredient=true;
        }
    }


    public void DishSelection (int DishIndex)
    {

    }




}
