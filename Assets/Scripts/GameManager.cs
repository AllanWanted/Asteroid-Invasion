using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Scene GameScene;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void VolverAJugar()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void EmpezarAJugar()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void SalirDelJuego()
    {
        Application.Quit();
    }
    public void VolverMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
