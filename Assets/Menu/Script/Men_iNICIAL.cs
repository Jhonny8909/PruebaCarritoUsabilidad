using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Men_iNICIAL : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Juego");
        Time.timeScale = 1f;
        
    }

    public void Salir()
    {
        Debug.Log("salir...");
        Application.Quit();
    }
}


