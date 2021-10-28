using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAsteroid : MonoBehaviour
{
    public bool BigAsteroid;

    public GameObject LittleAsteroidPrefab;


    void Colision()
    {
        if(BigAsteroid)
        {
            Instantiate(LittleAsteroidPrefab, transform.position + Random.onUnitSphere * .3f, Quaternion.identity);
            Instantiate(LittleAsteroidPrefab, transform.position + Random.onUnitSphere *.3f, Quaternion.identity);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
