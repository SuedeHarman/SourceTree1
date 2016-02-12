using UnityEngine;
using System.Collections;

public class ifscript : MonoBehaviour
{
    public int battery = 100;

    void Update()
    {
        if ( battery == 100)
        {
            Debug.Log("Full Power");
        }
        else if (battery == 0)
        {
            Debug.Log("No Power");
        }
        else
        {
            Debug.Log("Power Level Dropping");
        }
    }
}