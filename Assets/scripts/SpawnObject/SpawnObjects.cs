using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{

    public GameObject[] enemies;
    
    public float timeSpawnEnemies = 1;
    public float repeatSpawnRateEnemies = 3;



    public GameObject[] Objects;

    public float timeSpawnFruits = 1;
    public float repeatSpawnRateObjects = 3;

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

        if (difficulty > 10 && difficulty < 20)
        {
            repeatSpawnRateEnemies = 5;
            repeatSpawnRateObjects =  2;
        }
        if (difficulty > 20 && difficulty < 30)
        {
            repeatSpawnRateEnemies = 4;
            repeatSpawnRateObjects = 3;
        }
        if (difficulty > 30 && difficulty < 40)
        {
            repeatSpawnRateEnemies = 3;
            repeatSpawnRateObjects = 4;
        }
        if (difficulty > 40 && difficulty < 50)
        {
            repeatSpawnRateEnemies = 2;
            repeatSpawnRateObjects = 5;
        }
        if (difficulty > 50)
        {
            repeatSpawnRateEnemies = 1;
            repeatSpawnRateObjects = 6;
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
        SpawnEnemies();
        StartCoroutine("ObjectsDifficulty");
    }

    public void SpawnEnemies()
    {
        Vector3 spawnPosition = new Vector3(0,0,0);
        
        spawnPosition = new Vector3(Random.Range(XrangeLeft.position.x,XrangeRight.position.x),Random.Range(YrangeDown.position.y,YrangeUp.position.y),0);

        GameObject enemie = Instantiate(enemies[Random.Range(0,enemies.Length)], spawnPosition, gameObject.transform.rotation);
    }
    public void SpawnFruits()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(XrangeLeft.position.x, XrangeRight.position.x), Random.Range(YrangeDown.position.y, YrangeUp.position.y), 0);

        GameObject fruit = Instantiate(Objects[Random.Range(0, enemies.Length)], spawnPosition, gameObject.transform.rotation);
    }
}
