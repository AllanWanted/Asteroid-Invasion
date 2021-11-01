using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeShip : MonoBehaviour
{   
    //variables para la vida
    public int CantidadDeVidas = 3;
    public Image Img;
    // aca se utlizara los sprites de corazones para que represente la vida de la nave
    public Sprite TresVidas;
    public Sprite DosVidas;
    public Sprite UnaVida;

    public AudioSource au;

    private void Start()
    {
        CantidadDeVidas = 3;
        Img.sprite = TresVidas;
    }

    public void Damage()
    {
        CantidadDeVidas--;

        if(CantidadDeVidas == 3)
        {
            Img.sprite = TresVidas;
            au.Play();

        }
        else if (CantidadDeVidas == 2)
        {
            Img.sprite = DosVidas;
            au.Play();
        }
        else if (CantidadDeVidas == 1)
        {
            Img.sprite = UnaVida;
            au.Play();
        }
        else
        {
            SceneManager.LoadScene("Perdio");
        }


    }
}
