using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuFunc : MonoBehaviour
{
    public GameObject Shop;
    public GameObject Factory_1;
    public GameObject Factory_2;
    //public GameObject Factory_3;
    private bool isActive;
    public bool puedeMoverse;


    void Start() {
        isActive = false;
        Shop.SetActive(isActive);
        Factory_1.SetActive(isActive);
    }
 
    void Update()
    {
 
    }

    void OnTriggerStay(Collider other) {
        
        /*if (other.tag == "crystal")
        {

            Debug.Log("Toca crystal");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                other.GetComponent<crytal>().Cantidad = other.GetComponent<crytal>().Cantidad - 10;

                globalvariables.crystalCount += 10;
            }
        }
        */
        if (other.tag == "home")
        {
            globalvariables.aireRestante = 40 + (shopmethods.Casco * 20);
           

            if (Input.GetKeyDown(KeyCode.P))
            {
                Shop.SetActive(!isActive);
                isActive = !isActive;
                if (isActive == true)
                {
                    puedeMoverse = false;
                }
                else {
                    puedeMoverse = true;
                }
            }
        }
        if (other.tag == "factory")
        {
            globalvariables.aireRestante = 40 + (shopmethods.Casco * 20);


            if (Input.GetKeyDown(KeyCode.P))
            {
                Factory_1.SetActive(true);
                isActive = !isActive;
                if (isActive == true)
                {
                    puedeMoverse = false;
                }
                else
                {
                    puedeMoverse = true;
                    Factory_1.SetActive(false);
                    Factory_2.SetActive(false);
                    //Factory_3.SetActive(!isActive);
                }
            }
        }








        /* void OnTriggerEnter(Collider other)
         {
             if(other.tag == "home")
             {
                 velocidadAuxiliar = velocidad;
             }

         }

         void VoidOnTriggerExit(Collider other)
         {
             if (other.tag == "home")
             {
                 velocidad = velocidad + velocidadAuxiliar;
             }

         }*/


    }

}
