using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrada : MonoBehaviour{

    public Transform posA;
    public Camera PlayerCamera;
    public Camera InteriorCamera;

    [Header("Objetos")]
    public GameObject cama;
    public GameObject lampara;
    public GameObject flor;

    [Header("Particulas")]
    public Explosion pepe;
    public Transform insUno;
    public Transform insDos;
    public Transform insTres;
    //public Transform insCuatro;

    void OnTriggerEnter(Collider otro)
    {
        if (otro.tag == "Player")
        {
            if (globalvariables.cama) //si compramos estas cosas activarlas con las particulas
            {
                pepe.transform.position = insUno.position;
                pepe.Play();
                cama.SetActive(true);
                globalvariables.cama = false; //es esto o crear otro bool para preguntar si ya spawneo la particula
            }
            if (globalvariables.flor)
            {
                pepe.transform.position = insDos.position;
                pepe.Play();
                flor.SetActive(true);
                globalvariables.flor = false;
            }
            if (globalvariables.ilumination)
            {
                pepe.transform.position = insTres.position;
                pepe.Play();
                lampara.SetActive(true);
                globalvariables.ilumination = false;
            }

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
