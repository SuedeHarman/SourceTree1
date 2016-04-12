using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {

    public float rotationSpeed;
    public float movementSpeed;
    private Rigidbody rigidBody;

	void Start ()
    {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -rotationSpeed, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, rotationSpeed, 0));
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidBody.AddRelativeForce(0, 0, movementSpeed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidBody.AddRelativeForce(0, 0, -movementSpeed);
        }
    }
}
