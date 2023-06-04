using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioJugador : MonoBehaviour
{
    private void Start()
    {
        int indexJugador = PlayerPrefs.GetInt("JugadorIndex");
        Instantiate(GameManger.Instance.personajes[indexJugador].personajeJugable,transform.position,Quaternion.identity);
    }
}
