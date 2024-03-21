using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public GameObject roof;
    public GameObject poleLeft;
    public GameObject poleRight;

    public float interpolation = 1;
    public AnimationCurve curve;
    float speed1, speed2, speed3;
 

    Coroutine buildingSizeUp;


    // Start is called before the first frame update
    void Start()
    {
       
        if (buildingSizeUp != null)
        {
            StopCoroutine(buildingSizeUp);
        }
        buildingSizeUp = StartCoroutine(StartBuilding());
    }






    // Update is called once per frame
   void Update()
    {


        
        speed1 += 0.1f * Time.deltaTime;
        poleLeft.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (interpolation) * speed1 );
        
        speed2 += 0.1f * Time.deltaTime;
        poleRight.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (interpolation) * speed2);
        

        speed3 += 0.1f * Time.deltaTime;
        roof.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (interpolation) * speed3);
        


    }



    IEnumerator StartBuilding()
    {
        speed1 = 0;
        poleLeft.SetActive(true);
        yield return new WaitForSeconds(2f);
        speed2 = 0;
        poleRight.SetActive(true);
        yield return new WaitForSeconds(2f);
        speed3 = 0;
        roof.SetActive(true);




    }
}
