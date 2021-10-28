using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class AsteroidScript : MonoBehaviour
{
    public float Speed = 6;
     Rigidbody rig;

    

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = Vector3.back * Speed + Vector3.right * Random.Range(-1, 1);
        rig.angularVelocity = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
    }

    
    void Colision()
    {

    }
    
        
   
}
