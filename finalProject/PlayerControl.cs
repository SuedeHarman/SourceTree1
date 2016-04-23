﻿using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
    /*
    * Additional Variables:
    * A public GameObject that will hold the reference to the bullet prefab
    */

    /*
     * Additional Lines in the Update Function:
     *      If (the space bar is pressed down *see below for instructions*)
     *          Instantiate using the bullet prefab, this object's transform, and this object's rotation
     */

    /* **************Explanation and Hints************ 
     * Prefab - They are GameObjects that are stored outside of the scene. We use them to instantiate      
     *          GameObjects. 
     *
     * Instantiate - This will create a new GameObject or prefab of our choosing. In this script we want to
     *               create bullets. We will create the bullets at the players position and we will
     *               have the bullet match the rotation of the player. To do so we will type:
     *             
     *               Instantiate(*nameOfBulletVariable*, transform.position, transform.rotation);
     *
     * Pressing Space Bar - When shooting we want to use a different key press then the others. For this we
     *                      will be using Input.GetKeyDown. The reason why is because GetKeyDown only activates
     *                      once while GetKey activates multiple times. GetKeyDown is typed like this:
     *              
     *                      if(Input.GetKeyDown(KeyCode.Space))
     *                      {
     *                          //Instantiate bullet here
     *                      }
     */
}
