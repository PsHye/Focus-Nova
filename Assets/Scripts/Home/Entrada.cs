using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrada : MonoBehaviour
{
    public Transform posA;
    public Camera PlayerCamera;
    public Camera InteriorCamera;

    void OnTriggerEnter(Collider otro)
    {
        if (otro.tag == "Player")
        {
            globalvariables.zonaSegura = true;
            
            otro.transform.position = posA.position;
            PlayerCamera.enabled = false;
            InteriorCamera.enabled = true;
            otro.transform.GetComponent<PlayerController>().inside = true;
            InteriorCamera.GetComponent<AudioSource>().Play();
            PlayerCamera.GetComponent<AudioSource>().Stop();
        }
    }
}
