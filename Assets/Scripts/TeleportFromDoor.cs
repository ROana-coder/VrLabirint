using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportFromDoor : MonoBehaviour
{
    public GameObject o;
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            Vector3 temp = new Vector3(0, 0, 0);
            o.transform.position = temp;
        }
    }
}
