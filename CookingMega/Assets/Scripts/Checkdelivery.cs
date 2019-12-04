using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkdelivery : MonoBehaviour
{
    public bool delivery = false;
    public GameObject deliverplate;
    GameObject Deliver;
    float timer = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(delivery)
        {
            Foodgiving();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player" )
        {
            if(playerMovements.Currentfood==Npcbehaviour.oderedmeat)
            {
                Debug.Log("Food is right");
                delivery = true;
                
            }
            else
            {
                Debug.Log("Food is Wrong");
            }
        }
    }

    void Foodgiving()
    {
        Deliver = GameObject.FindGameObjectWithTag("cheese");
        Deliver.transform.position = deliverplate.transform.position;
        Deliver.transform.parent = GameObject.Find("Serverplate").transform;
        
        Debug.Log("Food is Deliverd");
        Disapper();
    }


    void Disapper()
    {
        Destroy(Deliver, timer);
        Debug.Log("Food Destroyed");
        delivery = false;
        playerMovements.canhold = true;
    }


}
