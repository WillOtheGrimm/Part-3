using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggers;
    public Transform spawnPoint;
    public Transform spawnPoint2;
    
    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }




    protected override void Attack()
    {
        destination = transform.position;
        base.Attack();
        Instantiate(daggers, spawnPoint.position, spawnPoint.rotation);
        Instantiate(daggers, spawnPoint2.position, spawnPoint2.rotation);


        speed = 10; 
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        
    }


}




