﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrada : MonoBehaviour{

    public Transform posA;
    public Camera PlayerCamera;
    public Camera InteriorCamera;

    [Header("Objetos Casa")]
    public GameObject cama;
    public GameObject lampara;
    public GameObject flor;
    public GameObject radioGO1;
    public GameObject radioGO2;
    public GameObject radioGO3;
    public GameObject radioGO4;

    [Header("Particulas")]
    public Explosion scriptDeExplosion;
    public Transform insUno;
    public Transform insDos;
    public Transform insTres;
    //public Transform insCuatro;

    private void Start()
    {
        cama.SetActive(false);
        lampara.SetActive(false);
        flor.SetActive(false);
        radioGO1.SetActive(false);
        radioGO2.SetActive(false);
        radioGO3.SetActive(false);
        radioGO4.SetActive(false);
    }

    void OnTriggerEnter(Collider otro)
    {
        if (otro.tag == "Player")
        {
            if (TiendaGlobal.INS.cama) //si compramos estas cosas activarlas con las particulas
            {
                scriptDeExplosion.transform.position = insUno.position;
                scriptDeExplosion.Play();
                cama.SetActive(true);
                TiendaGlobal.INS.cama = false; //es esto o crear otro bool para preguntar si ya spawneo la particula
            }
            if (TiendaGlobal.INS.flor)
            {
                scriptDeExplosion.transform.position = insDos.position;
                scriptDeExplosion.Play();
                flor.SetActive(true);
                TiendaGlobal.INS.flor = false;
            }
            if (TiendaGlobal.INS.ilumination)
            {
                scriptDeExplosion.transform.position = insTres.position;
                scriptDeExplosion.Play();
                lampara.SetActive(true);
                TiendaGlobal.INS.ilumination = false;
            }
            if (TiendaGlobal.INS.PiezaRadio1)
            {
                radioGO1.SetActive(true);
                TiendaGlobal.INS.PiezaRadio1 = false;
            }
            if (TiendaGlobal.INS.PiezaRadio2)
            {
                radioGO2.SetActive(true);
                TiendaGlobal.INS.PiezaRadio2 = false;
            }
            if (TiendaGlobal.INS.PiezaRadio3)
            {
                radioGO3.SetActive(true);
                radioGO4.SetActive(true);
                TiendaGlobal.INS.PiezaRadio3 = false;
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
