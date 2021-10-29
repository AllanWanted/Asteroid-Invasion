using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAsteroids : MonoBehaviour
{

    public float InstanceRate = 3;
    public GameObject AsteroidPrefab;

    private IEnumerator Start()
    {
        while (true)
        {
            Instantiate(AsteroidPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(InstanceRate);
        }
    }
}
