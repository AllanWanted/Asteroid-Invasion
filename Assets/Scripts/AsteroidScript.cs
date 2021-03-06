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
        // movimiento y aparicion del asteroide de forma aleatoria, para que no salga solo del mismo lado.
        rig.velocity = Vector3.back * Speed + Vector3.right * Random.Range(-1, 1);
        //script para que el asteroide gire de forma aleatoria, que no solo se muestre un lado del asteroide
        rig.angularVelocity = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        col.SendMessage("Damage", SendMessageOptions.DontRequireReceiver);
        
    }


}
