using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{

    public float timeAmount;
	
	void Update()
    {
        checkTimer();
	}

    void checkTimer()
    {
        timeAmount -= Time.deltaTime;
        if (timeAmount < 0)
        {
            Destroy(gameObject);
        }
    }
}
