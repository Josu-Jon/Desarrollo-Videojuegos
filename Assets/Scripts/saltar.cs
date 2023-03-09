using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class saltar : MonoBehaviour
{
    [Serialize]
    public int FuerzaSalto = 2;
    [Serialize]
    public int FuerzaMovimiento = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Rotation();
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * FuerzaSalto);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * FuerzaMovimiento);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.down * FuerzaMovimiento);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.left * FuerzaMovimiento);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.right * FuerzaMovimiento);
        }
    }

    private void Rotation()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.GetComponent<Transform>().transform.rotation *= Quaternion.Euler(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.GetComponent<Transform>().transform.rotation *= Quaternion.Euler(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Transform>().transform.rotation *= Quaternion.Euler(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.GetComponent<Transform>().transform.rotation *= Quaternion.Euler(0, 0, -1);
        }
    }
}
