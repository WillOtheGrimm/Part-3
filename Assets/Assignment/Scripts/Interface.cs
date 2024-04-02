using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Interface : MonoBehaviour
{
  
    public GameObject[] dropDownPrefabs = new GameObject[3];
    protected GameObject itemInstance;
    public TMP_Dropdown dropdown;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            //    hasIngredient = false; 
           // Debug.Log(ingredient);
        }
    }


    public void DropdownSelection (int index)
    {
        if (itemInstance == null && index !=0)
        {
            itemInstance = Instantiate(dropDownPrefabs[index]);
        }

            dropdown.value = 0;
    }


    public void ClearItems()
    {
       Destroy(itemInstance);
    }

    

    public virtual bool CanCook()
    {
        return false;
    }


    public virtual IEnumerator CookingAnimationRoutine()
    {
        return null;
    }


}