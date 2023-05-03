using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{

    public GameObject[] enemies;

    public float timeSpawn = 1;

    public float repeatSpawnRate = 3;

    public Transform XrangeLeft;
    public Transform XrangeRight;

    public Transform YrangeUp;
    public Transform YrangeDown;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnEnemies",timeSpawn,repeatSpawnRate);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemies()
    {

        Vector3 spawnPosition = new Vector3(0,0,0);
        
        spawnPosition = new Vector3(Random.Range(XrangeLeft.position.x,XrangeRight.position.x),Random.Range(YrangeDown.position.y,YrangeUp.position.y),0);

        GameObject enemie = Instantiate(enemies[0], spawnPosition, gameObject.transform.rotation);
    }
}
