using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuSeleccionPersonajes : MonoBehaviour
{
    private int index;
    [SerializeField] private Image imagen;
    [SerializeField] private TextMeshProUGUI nombre;
    private GameManger gameManger;

    private void Start()
    {
        gameManger = GameManger.Instance;
        
        index = PlayerPrefs.GetInt("JugadorIndex");

        if (index > gameManger.personajes.Count -1)
        {
            index = 0;
        }

        CambiarPantalla();
    }

    private void CambiarPantalla()
    {
        PlayerPrefs.SetInt("JugadorIndex", index);
        imagen.sprite = gameManger.personajes[index].imagen;
        nombre.text = gameManger.personajes[index].nombre;
    }

    public void SiguientePersonaje()
    {
        if (index == gameManger.personajes.Count - 1)
        {
            index = 0;
        }
        else
        {
            index += 1;
        }
        CambiarPantalla();
    }
    
    public void AnteriorPersonaje()
    {
        if (index == 0)
        {
            index = gameManger.personajes.Count -1;
        }
        else
        {
            index -= 1;
        }
        CambiarPantalla();
    }

    public void IniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
