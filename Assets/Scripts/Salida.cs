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
            
            InteriorCamera.enabled = false;
            CamaraSoloBloom.enabled = false;
            PlayerCamera.enabled = true;
            InteriorCamera.GetComponent<CamaraInterior>().enabled = false;
            otro.transform.GetComponent<PlayerController>().inside = false;
            InteriorCamera.GetComponent<AudioSource>().Stop();
            PlayerCamera.GetComponent<AudioSource>().Play();
        }
    }
}
