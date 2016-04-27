using UnityEngine;
using System.Collections;

public class bulletControl : MonoBehaviour
{
    private Rigidbody rigidBody;
    public float bulSpeed;
    private int wkDamage;
    private int strDamage;
    private int supstrDamage;
    private enemyDamage enemyDmg;

	void Start ()
    {
        rigidBody = GetComponent<Rigidbody>();
        wkDamage = 1;
        strDamage = 5;
        supstrDamage = 10;
	}
	
	void Update ()
    {
        rigidBody.AddForce(transform.forward * bulSpeed);
	}

    void OnTriggerEnter(Collider shot)
    {
        if(shot.transform.tag == "Enemy")
        {
            enemyDmg = shot.transform.GetComponent<enemyDamage>();
            switch (enemyDmg.enemyNumber)
            {
                case enemyDamage.EnemyTypes.enemyCylinder:
                    enemyDmg.damage(wkDamage);
                    break;
                case enemyDamage.EnemyTypes.enemyCube:
                    enemyDmg.damage(strDamage);
                    break;
                case enemyDamage.EnemyTypes.enemyCapsule:
                    enemyDmg.damage(supstrDamage);
                    break;
            }
            Destroy(gameObject);
        }
    }
}
