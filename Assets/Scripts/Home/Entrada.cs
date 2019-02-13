using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AuraAPI;

public class Entrada : MonoBehaviour{

    public Transform posA;
    public Camera PlayerCamera;
    public Camera InteriorCamera;
    public Camera CamaraSoloBloom;

    [Header("Objetos Casa")]
    public GameObject cama;
    public GameObject flor;
    public GameObject lampara;
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

    public AuraLight referenciaAuraLight;
    public GameObject cosasInteriorNave; //Esto va a estar todo desactivado al principio para reducir drawCalls y los batches MUCHISIMO, y los fps nos lo agradecen

    private void Awake()
    {
        cosasInteriorNave.SetActive(false);
    }                                                              

    void OnTriggerEnter(Collider otro)
    {
        if (otro.transform.CompareTag("Player"))
        {
            cosasInteriorNave.SetActive(true); //activo todo apenas entro
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
            referenciaAuraLight.enabled = true;
            PlayerCamera.gameObject.SetActive(false);    
            //IMPORTANTE:
            //InteriorCamera.enabled = true; //Esto lo puedo comentar por que es hijo del obj vacio que activo mas arriba, pero la camara de abajo es hijo del hijo y no se va a activar de la misma forma.
            CamaraSoloBloom.enabled = true; // La camara del bloom siosi despues de la del interior asi llega a renderizar primero la de interior y DESPUES la del bloom

            otro.transform.GetComponent<PlayerController>().inside = true;
            InteriorCamera.GetComponent<AudioSource>().Play();
            PlayerCamera.GetComponent<AudioSource>().Stop();
        }
    }
}
