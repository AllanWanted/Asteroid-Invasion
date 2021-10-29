using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAsteroid : MonoBehaviour
{
    public bool BigAsteroid;

    public GameObject LittleAsteroidPrefab;


    void Colision()
    {
        if (BigAsteroid == true)
        {
            Instantiate(LittleAsteroidPrefab, transform.position + Random.onUnitSphere * 10, Quaternion.identity);
            Instantiate(LittleAsteroidPrefab, transform.position + Random.onUnitSphere * 10, Quaternion.identity);
           
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider Col)
    {
        if (Col.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            
        }
    }

}
