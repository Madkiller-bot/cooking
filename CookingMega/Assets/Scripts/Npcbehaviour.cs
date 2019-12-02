using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Npcbehaviour : MonoBehaviour
{
    public GameObject waypoints;
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

        pickone();
    }


    void pickone()
    {

    }
}
