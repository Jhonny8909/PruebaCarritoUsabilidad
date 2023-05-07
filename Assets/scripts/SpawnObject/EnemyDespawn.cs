using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDespawn : MonoBehaviour
{
    [SerializeField] private float cooldownDespawn;
    [SerializeField] private float tiempoCooldown;
    public GameObject capsula;
    private void Update()
    {
        if (this.GetComponent<Renderer>().isVisible == false)
        {
            if (cooldownDespawn > 0)
            {
                cooldownDespawn -= Time.deltaTime;
            }
            if (cooldownDespawn <= 0)
            {
                Destroy(capsula);
            }

        }
        else
        {
            cooldownDespawn = tiempoCooldown;
        }
    }
}
