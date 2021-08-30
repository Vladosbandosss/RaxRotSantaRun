using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public static ObstacleSpawn instance;

    
    [SerializeField] GameObject [] obstacles;
    
    [SerializeField]public bool gameOver = false;

    [SerializeField] float minFloatTime;
    [SerializeField] float maxFloatTime;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        StartCoroutine(nameof(Spawn));
    }

   void SpawnObStacle()
    {
        int randomObstacle = Random.Range(0, obstacles.Length);
        Instantiate(obstacles[randomObstacle], transform.position, Quaternion.identity);
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1f);
        while (!gameOver)
        {
            float timeToSpawn = Random.Range(minFloatTime, maxFloatTime);
            SpawnObStacle();
            yield return new WaitForSeconds(timeToSpawn);
        }
       
    }
}
