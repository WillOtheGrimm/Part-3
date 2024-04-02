using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Interface : MonoBehaviour
{
    //List to keep the object for the dropdown to spawn
    public GameObject[] dropDownPrefabs = new GameObject[3];
    
    protected GameObject itemInstance;
    public TMP_Dropdown dropdown;
    public float speed = 5;


    //This Function spawns the prefab of the selection (from the dropdown)
    public void DropdownSelection (int index)
    {
        //Check if an item has been spawned and the dropdown index isnt 0
        if (itemInstance == null && index !=0)
        {
            itemInstance = Instantiate(dropDownPrefabs[index]);
        }
        //resets the dropdown to go back to initial index
            dropdown.value = 0;
    }

    //This funtion takes care of destroying the object on the scene
    public void ClearItem()
    {
       Destroy(itemInstance);
    }

    
    //this function is to be overriden to check is ingredients are present to allow cook button to work
    public virtual bool CanCook()
    {
        return false;
    }

    //this is for the animation when pressing cook
    public virtual IEnumerator CookingAnimationRoutine(Transform destination)
    {
        //this check it can cook 
        if (!CanCook()) yield break;

        //to make sure it keep running until the object is at desired location
        while (Vector3.Distance(itemInstance.transform.position, destination.position) > 0)
        {
            //this is to move the item from snapping location to the cooking spot
            itemInstance.transform.position = Vector3.MoveTowards(itemInstance.transform.position, destination.position, speed * Time.deltaTime);
            yield return null;
          
        }

    }
}