using UnityEngine;
using System.Collections;

public class Loop_Script2 : MonoBehaviour 
{

	int firewood = 0;

	void Start() 
	{
		while (firewood < 5)
		{
			Debug.Log ("I found some firewood");
			firewood++;
		}

		do {
			Debug.Log ("Collecting firewood");
			firewood++;
		} while(firewood < 10);

		for (int i = 0; i < firewood; i++) 
		{
			Debug.Log ("Used firewood");
		}

		int[] thing = new int[5];
		thing [0] = 1;
		thing [1] = 2;
		thing [2] = 10;
		thing [3] = 15;
		thing [4] = 18;

		foreach (int item in thing)
		{
			print (item);
		}
	}
}

