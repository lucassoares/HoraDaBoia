using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemy;
    public GameObject[] spawnEnemy;

    private float time;

	void Start ()
    {
        time = 0;
	}

	void Update ()
    {
        time = time + 1 * Time.deltaTime;

        if(time > 3)
        {
            int spawnPos = Random.Range(0, spawnEnemy.Length);
            int enemySpawn = Random.Range(0, enemy.Length);

            Instantiate(enemy[enemySpawn], spawnEnemy[spawnPos].transform.position, spawnEnemy[spawnPos].transform.rotation);
            time = 0;
        }
	}
}
