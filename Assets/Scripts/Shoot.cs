using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform LanzadorL;
    public Transform LanzadorR;

    public GameObject ShooterPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(ShooterPrefab, LanzadorL.position, ShooterPrefab.transform.rotation);
            Instantiate(ShooterPrefab, LanzadorR.position, ShooterPrefab.transform.rotation);
        } 
    }
}
