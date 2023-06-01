using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnObjects : MonoBehaviour
{
    public TextMeshProUGUI nivel;
    private string enunciado;

    public GameObject[] enemies;
    
    public float timeSpawnEnemies = 0;
    public float repeatSpawnRateEnemies = 0;



    public GameObject[] Objects;

    public float timeSpawnFruits = 0;
    public float repeatSpawnRateObjects = 0;

    public Transform XrangeLeft;
    public Transform XrangeRight;

    public Transform YrangeUp;
    public Transform YrangeDown;

    public float difficulty = 0;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("EnemyDifficulty");
        StartCoroutine("ObjectsDifficulty");
    }

    // Update is called once per frame
    void Update()
    {
        difficulty += Time.deltaTime;

        if (difficulty > 0 && difficulty < 10)
        {
            repeatSpawnRateEnemies = 5;
            repeatSpawnRateObjects = 2;
            enunciado = "Nivel 1";
            nivel.text = enunciado;
        }
        if (difficulty > 10 && difficulty < 20)
        {
            repeatSpawnRateEnemies = 4;
            repeatSpawnRateObjects =  2;
            enunciado = "Nivel 2";
            nivel.text = enunciado;
        }
        if (difficulty > 20 && difficulty < 30)
        {
            repeatSpawnRateEnemies = 3;
            repeatSpawnRateObjects = 3;
            enunciado = "Nivel 3";
            nivel.text = enunciado;
        }
        if (difficulty > 30 && difficulty < 40)
        {
            repeatSpawnRateEnemies = 2;
            repeatSpawnRateObjects = 4;
            enunciado = "Nivel 4";
            nivel.text = enunciado;
        }
        if (difficulty > 40 && difficulty < 50)
        {
            repeatSpawnRateEnemies = 1;
            repeatSpawnRateObjects = 5;
            enunciado = "Nivel 5";
            nivel.text = enunciado;
        }
        if (difficulty > 50)
        {
            repeatSpawnRateEnemies = .5f;
            repeatSpawnRateObjects = 6;
            enunciado = "Nivel 6";
            nivel.text = enunciado;
        }
    }

    IEnumerator EnemyDifficulty()
    {
        yield return new WaitForSeconds(repeatSpawnRateEnemies);
        SpawnEnemies();
        StartCoroutine("EnemyDifficulty");
    }

    IEnumerator ObjectsDifficulty()
    {
        yield return new WaitForSeconds(repeatSpawnRateObjects);
        Spawn();
        StartCoroutine("ObjectsDifficulty");
    }

    public void SpawnEnemies()
    {
        Vector3 spawnPosition = new Vector3(0,0,0);
        
        spawnPosition = new Vector3(Random.Range(XrangeLeft.position.x,XrangeRight.position.x),Random.Range(YrangeDown.position.y,YrangeUp.position.y),0);

        GameObject enemie = Instantiate(enemies[Random.Range(0,enemies.Length)], spawnPosition, gameObject.transform.rotation);
    }
    public void Spawn()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(XrangeLeft.position.x, XrangeRight.position.x), Random.Range(YrangeDown.position.y, YrangeUp.position.y), 0);

        GameObject fruit = Instantiate(Objects[Random.Range(0, Objects.Length)], spawnPosition, gameObject.transform.rotation);
    }
}
