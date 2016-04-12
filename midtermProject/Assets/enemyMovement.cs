using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour
{

    private Rigidbody rigidBody;
    public float movementSpeed;
    private Vector3 enemyDirection;
	void Start ()
    {
        rigidBody = GetComponent<Rigidbody>();
        enemyDirection = new Vector3(0, Random.Range(0, 360), 0);
        transform.eulerAngles = enemyDirection;
	}
	
	void Update ()
    {
        rigidBody.AddRelativeForce(transform.forward * movementSpeed);
	}
}
