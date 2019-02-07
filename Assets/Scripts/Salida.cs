using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salida : MonoBehaviour
{
    public Transform posA;
    public Camera PlayerCamera;
    public Camera InteriorCamera;
    public Camera CamaraSoloBloom;

    void OnTriggerEnter(Collider otro)
    {
        if (otro.tag == "Player")
        {
            globalvariables.zonaSegura = false;
            
            otro.transform.position = posA.position;
            PlayerCamera.enabled = true;
            InteriorCamera.enabled = false;
            CamaraSoloBloom.enabled = false;
            otro.transform.GetComponent<PlayerController>().inside = false;
            InteriorCamera.GetComponent<AudioSource>().Stop();
            PlayerCamera.GetComponent<AudioSource>().Play();
        }
    }
}
