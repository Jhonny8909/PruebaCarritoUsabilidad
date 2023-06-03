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
        
    }

    public void PlayerDamaged()
    {
        life--;
        if (life < 1)
        {
            hearts[0].SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (life < 2)
        {
            hearts[1].SetActive(false);
        }
        else if (life < 3)
        {
            hearts[2].SetActive(false);
        }
        Debug.Log(life);

    }

    public void PlayerHealed()
    {
        life++;
        if (life == 2)
        {
            hearts[1].SetActive(true);

        }
        else if (life == 3)
        {
            hearts[2].SetActive(true);
            
        }else if (life == 4)
        {
            life--;
        }
        
    }
}
