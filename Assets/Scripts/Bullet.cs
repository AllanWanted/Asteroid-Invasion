using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Velocity = 20;

    // Start is called before the first frame update
    void Start()
    {   
        //tiempo en que la bala se destruye.
        Destroy(gameObject, 0.5f); 
    }
    

    // Update is called once per frame
    void Update()
    {   
        //se regula el tiempo de la bala segun los FPS del juego.
        transform.position += transform.up * Velocity * Time.deltaTime;
    }
   




}
