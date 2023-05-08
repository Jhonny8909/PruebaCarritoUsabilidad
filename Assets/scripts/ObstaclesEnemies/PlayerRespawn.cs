using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;

    private void Start()
    {
        life = hearts.Length;
    }
    private void Update()
    {
        if (life < 1)
        {
            hearts[0].SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (life < 2)
        {
            hearts[0].SetActive(false);
        }
        else if (life < 3)
        {
            hearts[0].SetActive(false);
        }
    }

    public void PlayerDamaged()
    {
        life--;

    }
}
