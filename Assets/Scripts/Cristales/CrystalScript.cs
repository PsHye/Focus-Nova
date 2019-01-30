using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalScript : MonoBehaviour {

    // Use this for initialization
    public GameObject Fase1;
    public GameObject Fase2;
    public GameObject Fase3;
    public GameObject Fase4;

    public int Cantidad = 160;

	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

	switch(Cantidad)
	{
		case 160:
                Fase1.SetActive(true);
                Fase2.SetActive(false);
                Fase3.SetActive(false);
                Fase4.SetActive(false);
                break;
		case 120:
                Fase1.SetActive(false);
                Fase2.SetActive(true);
                Fase3.SetActive(false);
                Fase4.SetActive(false);
        break;
		case 80:
                Fase1.SetActive(false);
                Fase2.SetActive(false);
                Fase3.SetActive(true);
                Fase4.SetActive(false);

        break;
		case 30:
                Fase1.SetActive(false);
                Fase2.SetActive(false);
                Fase3.SetActive(false);
                Fase4.SetActive(true);

        break;
		case 0:
		Destroy(gameObject);
		break;
		
	}

		
	}
}
