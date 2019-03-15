using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salida : MonoBehaviour
{
    public Transform posA;
    public Camera PlayerCamera;
    public Camera InteriorCamera;
    public Camera CamaraSoloBloom;
    public Camera CamaraSoloBloomEXTERIOR;
    public GameObject cosasInteriorNave;


    void OnTriggerEnter(Collider otro)
    {
        if (otro.transform.CompareTag("Player"))
        {
            cosasInteriorNave.SetActive(false);
            globalvariables.zonaSegura = false;
            
            otro.transform.position = posA.position;
            CamaraSoloBloom.enabled = false;
            CamaraSoloBloomEXTERIOR.gameObject.SetActive(true);
            PlayerCamera.gameObject.SetActive(true);
            otro.transform.GetComponent<PlayerController>().inside = false;
            InteriorCamera.GetComponent<AudioSource>().Stop();
            PlayerCamera.GetComponent<AudioSource>().Play();
        }
    }
}
