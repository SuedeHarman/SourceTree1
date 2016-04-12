using UnityEngine;
using System.Collections;

public class enemyDamage : MonoBehaviour
{

	
	void OnCollisionEnter (Collision collide)
    {
	    if(collide.transform.tag == "Killzone")
        {
            Destroy(gameObject);
        }
	}
	
}
