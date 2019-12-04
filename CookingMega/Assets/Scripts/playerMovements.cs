using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovements : MonoBehaviour
{

    public static bool canhold = true; // used as a Hand for player to hold the Item
    GameObject Cheese;
    GameObject CookingArea;
    public Transform objtrans;
    public static string Currentfood;
    public float speed;// the Destination of the food in players position


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("input1")* speed * Time.deltaTime, 0, Input.GetAxis("inputv2") * Time.deltaTime*speed);
        if (Input.GetMouseButton(0))
        {
            if (!canhold)
                throw_drop();
            else
                picking();

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cheese")
        {
            if (!Cheese) // if we don't have anything holding
                Cheese = other.gameObject;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "cheese")
        {
            if (canhold)
                Cheese = null;
        }
    }

    void picking()
    {
        if (!Cheese)
            return;


        Cheese.transform.SetParent(objtrans);
        Cheese.transform.localRotation = transform.rotation;
        
        Cheese.transform.position = objtrans.position;
        canhold = false;
    }

  

    void throw_drop()
    {
      
    }
}
