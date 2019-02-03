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
    public Explosion scriptDeExplosion;
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
                scriptDeExplosion.transform.position = insUno.position;
                scriptDeExplosion.Play();
                cama.SetActive(true);
                globalvariables.cama = false; //es esto o crear otro bool para preguntar si ya spawneo la particula
            }
            if (globalvariables.flor)
            {
                scriptDeExplosion.transform.position = insDos.position;
                scriptDeExplosion.Play();
                flor.SetActive(true);
                globalvariables.flor = false;
            }
            if (globalvariables.ilumination)
            {
                scriptDeExplosion.transform.position = insTres.position;
                scriptDeExplosion.Play();
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
