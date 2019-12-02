using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    private GameObject food;
    public GameObject dropplace;
    public bool cooking;
    Collider b_collier;


    private void Start()
    {
        b_collier = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        food = GameObject.FindGameObjectWithTag("cheese");

        food.transform.position = dropplace.transform.position;
        food.transform.parent = GameObject.Find("CookingPan").transform;

        cooking = true;
        if (cooking = true)
        {
            b_collier.enabled = false;
        }
        //if( Input.GetKeyDown(KeyCode.E))
        //{
        //    food.transform.parent = GameObject.Find("ObjectTransform").transform;
        //}
    }
    private void OnTriggerExit(Collider other)
    {
        cooking = false;
        if (cooking = false)
        {
            b_collier.enabled = true;
        }
    }



}
