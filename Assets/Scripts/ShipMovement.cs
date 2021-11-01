using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// seguridad por si olvida el rigidbody, crea un restricion para que no sea eliminado
[RequireComponent(typeof(Rigidbody))]
public class ShipMovement : MonoBehaviour
{   
    //variable de movimiento.
    public float Velocity = 8;

    Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
       
        Vector3 DirectionX = Input.GetAxis ("Horizontal") *  Vector3.right;
        Vector3 DirectionZ = Input.GetAxis("Vertical") * Vector3.forward;

        Vector3 Direction = DirectionX + DirectionZ;
        Vector3 VectorVelocity = Direction * Velocity;

        rig.velocity = VectorVelocity;

    }
}
