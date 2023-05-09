using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public int moneda = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            FindObjectOfType<MenuManager>().AddPuntuation(moneda);
            Debug.Log(moneda);
            Destroy(gameObject);
        }
    }
}
