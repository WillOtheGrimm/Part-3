using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CharacterControl : MonoBehaviour
{
    public TextMeshProUGUI showSelected;
    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }


        SelectedVillager = villager;
        SelectedVillager.Selected(true);
    }
 

    private void Update()
    {
        if (SelectedVillager != null)
        {
        showSelected.text = SelectedVillager.CanOpen().ToString();
        }
        else
        {
            showSelected.text = "No selection";
        }
    }
}
