using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text t;
    public int puntaje;

    public static Points  puntajeActual;


     void Start()
    {
        puntajeActual = this;
    }


    public void PointUpdate()
    {
        puntaje++;
        t.text = puntaje.ToString();
    }
}
