using UnityEngine;
using System.Collections;

public class Switch_Statement : MonoBehaviour
{

    public int thing = 3;

    void Start ()
    {
        DoAThing();
    }

	void DoAThing ()
    {
        switch (thing)
        {
            case 3:
                print("Did a thing!");
                break;
            case 2:
                print("Half-did a thing");
                break;
            case 1:
                print("Tried to do animation thing");
                break;
            default:
                print("Did not do a thing");
                break;
         }
	}
	
}
