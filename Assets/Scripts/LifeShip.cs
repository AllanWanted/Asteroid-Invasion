using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeShip : MonoBehaviour
{
    public int CantidadDeVidas = 3;
    public Image Img;

    public Sprite TresVidas;
    public Sprite DosVidas;
    public Sprite UnaVida;

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
        }
        else if (CantidadDeVidas == 2)
        {
            Img.sprite = DosVidas;
        }
        else if (CantidadDeVidas == 1)
        {
            Img.sprite = UnaVida;
        }
        else
        {
            SceneManager.LoadScene("Perdio");
        }


    }
}
