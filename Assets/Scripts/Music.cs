using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource a;
    void OnTriggerEnter(Collider c)
    {
        if(c)
        a.Play();
    }
}
