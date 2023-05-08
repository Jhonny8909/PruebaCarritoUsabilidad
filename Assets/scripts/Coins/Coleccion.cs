using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccion : MonoBehaviour
{
    public int moneda = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindObjectOfType<MenuManager>().AddPuntuation(moneda);
            Destroy(gameObject);
        }
    }
}
