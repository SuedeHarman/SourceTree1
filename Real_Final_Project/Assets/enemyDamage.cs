using UnityEngine;
using System.Collections;

public class enemyDamage : MonoBehaviour
{
    public enum EnemyTypes {enemyCylinder, enemyCube, enemyCapsule};
    public EnemyTypes enemyNumber;
    public int enemyHealth;

    public void damage (int dmgAmount)
    {
        
        enemyHealth -= dmgAmount;
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

	void OnCollisionEnter (Collision collide)
    {
	    if(collide.transform.tag == "Killzone")
        {
            Destroy(gameObject);
        }
	}
	
}
