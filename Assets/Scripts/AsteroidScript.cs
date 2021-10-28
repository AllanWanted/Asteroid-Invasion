using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class AsteroidScript : MonoBehaviour
{
    public float Speed = 6;
     Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.back * Speed + Vector3.right * Random.Range(-1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
