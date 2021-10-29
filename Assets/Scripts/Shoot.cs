using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform LanzadorL;
    public Transform LanzadorR;

    public GameObject BulletPrefab;

    public AudioSource au;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            au.Play();

            Instantiate(BulletPrefab, LanzadorL.position, BulletPrefab.transform.rotation);
            Instantiate(BulletPrefab, LanzadorR.position, BulletPrefab.transform.rotation);

            
        } 
    }
    
}
