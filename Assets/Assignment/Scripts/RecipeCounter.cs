using TMPro;
using UnityEngine;

public class RecipeCounter : MonoBehaviour
{
    public TextMeshProUGUI counter;

    public static RecipeCounter singleton;
    private int recipeCount;


    //this set the singleton instance when the scene is loaded
    void Awake()
    {
        singleton = this;
    }

    //this clears the singleton instance if the scene gets unloaded
    void OnDestroy()
    {
        singleton = null;
    }

    //this is to display the Recipe count
    public static void AddRecipe()
    {
        singleton.recipeCount++;
        singleton.counter.text = "Recipes Created: " + singleton.recipeCount;
    }
}