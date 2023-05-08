using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Healed : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;

    private void Start()
    {
        life = hearts.Length;
    }
    private void Update()
    {
        
    }

    public void PlayerHealed()
    {
        life++;
        if (life < 2)
        {
            hearts[1].SetActive(true);

        }
        else if (life < 3)
        {
            hearts[2].SetActive(false);
        }
        
    }
}
