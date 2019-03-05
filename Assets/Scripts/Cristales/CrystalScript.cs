using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalScript : MonoBehaviour {

    public GameObject Fase1;
    public GameObject Fase2;
    public GameObject Fase3;
    public GameObject Fase4;

    public int Cantidad = 160;

    [Header("Sistema de particulas a apagar")] // Por ahora esto va a ser asi ok? no me juzgues
    public ParticleSystem particulaSystem;

    void Start () {
        Fase1.SetActive(true);
        Fase2.SetActive(false);
        Fase3.SetActive(false);
        Fase4.SetActive(false);
    }
	
	
    public void cantidadCristales()
    {
        switch (Cantidad)
        {
            case 160:
                Fase1.SetActive(true);
                break;
            case 120:
                Fase1.SetActive(false);
                Fase2.SetActive(true);
                break;
            case 80:
                Fase2.SetActive(false);
                Fase3.SetActive(true);
                break;
            case 30:
                Fase3.SetActive(false);
                Fase4.SetActive(true);
                break;
            case 0:
                Destroy(gameObject);
                particulaSystem.Stop();

                break;
        }
    }
}
