using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    Animator anim;
    bool doorOpen;
    void Start()
    {
        doorOpen = false;
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider col)
    {
       if(col.tag == "Player")
        {
            doorOpen = true;                                   
            Doors("openT");
        }
       
    }
    void OnTriggerExit(Collider col)
    {
        if(doorOpen)
        {
            doorOpen = false;
            Doors("closeT");
        }
    }
    void Doors(string direction)
    {
         anim.SetTrigger(direction);
    }
    
    
}
