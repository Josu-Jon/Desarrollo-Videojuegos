using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce(Vector3.up * 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
