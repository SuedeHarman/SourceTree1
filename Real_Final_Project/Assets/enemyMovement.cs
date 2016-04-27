using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour
{

    private Rigidbody rigidBody;
    public float movementSpeed;
    private Vector3 enemyDirection;
    private GameObject playerCube;
    private enemyDamage enemyDmg;

	void Start ()
    {
        rigidBody = GetComponent<Rigidbody>();
        
        transform.eulerAngles = enemyDirection;
        playerCube = GameObject.FindGameObjectWithTag("Player");
        enemyDmg = GetComponent<enemyDamage>();
        if(enemyDmg.enemyNumber == enemyDamage.EnemyTypes.enemyCylinder)
        {
            enemyDirection = new Vector3(0, Random.Range(0, 360), 0);
        }
	}
	
	void Update ()
    {
        rigidBody.AddRelativeForce(transform.forward * movementSpeed);
        if(enemyDmg.enemyNumber == enemyDamage.EnemyTypes.enemyCube)
        {
            transform.LookAt(playerCube.transform);
        }
        else if(enemyDmg.enemyNumber == enemyDamage.EnemyTypes.enemyCapsule)
        {
            transform.LookAt(playerCube.transform);
        }
	}
}
