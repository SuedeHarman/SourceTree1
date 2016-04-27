using UnityEngine;
using System.Collections;

public class enemySpawner : MonoBehaviour
{

    public GameObject[] enemies;
    private float invokeDelay;

	void Start ()
    {
        invokeDelay = 5;
        InvokeRepeating("enemySpawn", 0, invokeDelay);
	}
	
    void enemySpawn()
    {
        int enemyNum = 0;
        while(enemyNum < enemies.Length)
        {
            Vector3 enemyVector = transform.position;
            Instantiate(enemies[enemyNum],enemyVector,Quaternion.identity);
            enemyNum += 1;
        }
    }
}
