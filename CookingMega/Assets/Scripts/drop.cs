using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{

    public GameObject CookingTransform;
    public static bool cook = false;
    GameObject Food;
    float CookingTime = 0f;
    Renderer rend;
  //  public Material AfterBunMaterial;

    private void Start()
    {
       
    }
    public void Update()
    {
       
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (!playerMovements.canhold)
        {

            Debug.Log("Item in hand is true");
            Food = GameObject.FindGameObjectWithTag("cheese");
            Food.transform.position = CookingTransform.transform.position;
            Food.transform.parent = GameObject.Find("CookingPan").transform;
            cook = true;
            playerMovements.canhold = true;
           

        }
        else
        {
            Debug.Log("GO and GEt the Iteam");
        }








    }
}
        
      




