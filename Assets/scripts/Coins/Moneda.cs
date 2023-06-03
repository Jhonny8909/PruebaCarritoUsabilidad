using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public bool moneda = true;
    [SerializeField] private AudioClip colicion1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            FindObjectOfType<MenuManager>().AddPuntuation(moneda);
            ControladorSonido.Instance.EjecutarSonido(colicion1);
            Destroy(gameObject);
        }
    }
}
