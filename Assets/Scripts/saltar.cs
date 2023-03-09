using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class saltar : MonoBehaviour
{
    [Serialize]
    int FuerzaSalto = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(transform.up * FuerzaSalto);
        }
    }
}
