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
    public int puntos;

    public TextMeshProUGUI MxPuntuacion;
    public int MxPuntos;

    public float puntosfloat;
    public void Start()
    {
        MxPuntos = PlayerPrefs.GetInt("MxPuntosLogrados");
        MxPuntuacion.text = MxPuntos.ToString();
    }

    void Update()
    {
         
        puntosfloat += Time.deltaTime;
        puntos = Convert.ToInt32(puntosfloat);
        puntuacion.text = puntos.ToString();

        if (MxPuntos < puntos)
        {
            PlayerPrefs.SetInt("MxPuntosLogrados", puntos);
            MxPuntuacion.text = puntos.ToString();
        }
    }

    public void AddPuntuation(int puntuacion)
    {
        puntos += puntuacion;
    }
}
 