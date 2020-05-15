using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject obj;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            obj.GetComponent<Animation>().Play();
    }
}