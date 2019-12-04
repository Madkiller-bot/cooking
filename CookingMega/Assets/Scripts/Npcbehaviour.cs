using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Npcbehaviour : MonoBehaviour
{
    public GameObject waypoints;
    public static string oderedmeat;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(waypoints.transform.position);
        if (agent.remainingDistance > 0.1)
        {
            StartCoroutine(Destiny());
        }
       
    }

    IEnumerator Destiny()
    {
        yield return new WaitForSeconds(10);
        Debug.Log("Waiting for food");
        
    }
    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Counter")
        {
            oderedmeat = "Cheese";
            Debug.Log("Cheese Odered");
            
        }
    }

}
