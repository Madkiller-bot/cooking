using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookFood : MonoBehaviour
{
    public float cooktime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (drop.cook)
        {


            cooktime += Time.deltaTime;
            if (cooktime > 5 && cooktime < 10)
            {
                GetComponent<MeshRenderer>().material.color = Color.red;
                Debug.Log("Food Is Cooked");
                if(gameObject.name== "cheese")
                {
                    playerMovements.Currentfood = "Cheese";
                    Debug.Log("Cuurent food in had is cheese");
                }
                playerMovements.canhold = true; 

            }
            //if (cooktime > 10)
            //{
            //    GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0);
                
            //}
          
        }
    }
}
