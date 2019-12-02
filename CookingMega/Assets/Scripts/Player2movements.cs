using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2movements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("input2h") * Time.deltaTime, 0, Input.GetAxis("input2v") * Time.deltaTime);
    }
}
