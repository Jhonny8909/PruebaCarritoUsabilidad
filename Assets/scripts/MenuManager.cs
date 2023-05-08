using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI puntuacion;
    public float puntos;

    void Update()
    {
        puntos += Time.deltaTime;
        int puntosint = Convert.ToInt32(puntos);
        puntuacion.text = puntos.ToString();
    }
}
 