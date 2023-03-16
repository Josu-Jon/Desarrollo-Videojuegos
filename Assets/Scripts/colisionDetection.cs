using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionStay(Collision collision)
    {
        Debug.Log("Colision2");
        if (collision.gameObject.layer == LayerMask.NameToLayer("Wall"))
        {
            Debug.Log("Colision");
            Destroy(this.gameObject);
        }
    }
}
