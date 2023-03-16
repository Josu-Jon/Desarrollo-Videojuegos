using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwaner : MonoBehaviour
{
    public GameObject bala;
    public GameObject lanzador;
    [SerializeField]
    private float Fuerza  = 1000;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            GameObject newBullet = Instantiate(bala, lanzador.transform);
            newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * Fuerza);
        }
    }
}
