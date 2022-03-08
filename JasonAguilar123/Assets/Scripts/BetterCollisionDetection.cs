using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterCollisionDetection : MonoBehaviour
{
     void OnTriggerEnter(Collider other) //Enteing object in the first frame
    {
        if(other.gameObject.tag == "Line")
        {
            print("ENTER");
        }
    }
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Line") // checking each frame when entering a object
        {
            print("STAY");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Line")
        {
            print("EXIT"); // when exiting a game object 
        }
    }



}
