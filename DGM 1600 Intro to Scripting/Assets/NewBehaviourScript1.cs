using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour
{
    int myInt = 6;

    void Start()
    {
        myInt = Multiply(myInt);
        Debug.Log(myInt);
    }

    int Multiply (int number)
    {
        int sum;
        sum = number * 2;
        return sum;
    }
}
