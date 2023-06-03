using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private AudioClip colicion1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.GetComponent<PlayerRespawn>().PlayerHealed();
            ControladorSonido.Instance.EjecutarSonido(colicion1);
            Destroy(gameObject);
        }
    }
}
