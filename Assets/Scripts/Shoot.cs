using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{   

    // variables para definir el lado donde salen las balas ya creadas.
    public Transform LanzadorL; //lado izquierdo    
    public Transform LanzadorR; //lado derecho

    public GameObject BulletPrefab;

    public AudioSource au;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            au.Play();
            //crear un objeto en la escena
            Instantiate(BulletPrefab, LanzadorL.position, BulletPrefab.transform.rotation);
            Instantiate(BulletPrefab, LanzadorR.position, BulletPrefab.transform.rotation);

            
        } 
    }
    
}
