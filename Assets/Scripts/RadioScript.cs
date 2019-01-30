using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioScript : MonoBehaviour
{

    public GameObject Pieza1;
    public GameObject Pieza2;
    public GameObject Pieza3;

    void Start()
    {
        
    }

   
    void Update()
    {

        if(globalvariables.PiezaRadio1)
        {
            Pieza1.SetActive(true);
        }
        else
        {
            Pieza1.SetActive(false);
        }

        if (globalvariables.PiezaRadio2)
        {
            Pieza2.SetActive(true);
        }
        else
        {
            Pieza2.SetActive(false);
        }

        if (globalvariables.PiezaRadio3)
        {
            Pieza3.SetActive(true);
        }
        else
        {
            Pieza3.SetActive(false);
        }

        if(globalvariables.PiezaRadio3)
        {
            Debug.Log("Ganaste");
        }






    }
}
