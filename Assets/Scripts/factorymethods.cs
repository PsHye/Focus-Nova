using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class factorymethods : MonoBehaviour
{
    public Button parte1;
    public Button parte2;
    public Button parte3;
    public Button cajadeArenaButton;
    public Button plantitaButton;
    public Button iluminationButton;
    public GameObject cajaArena;
    public GameObject lampara;
    public GameObject flor;


  void Update() {
       /* 
        * 
        * ESTO LO SAQUE POR QUE NO SE QUE CHOTA HACE, Y NO CAMBIA NADA SI NO ESTA.
        * PUEDEN VOLVERLO A PONER SIN DRAMA. PERO HAY QUE ARREGLARLO.
        * 
        * 
        * 
        * if (globalvariables.crystalCount < 240)
        {
            cajadeArenaButton.image.color = Color.gray;
            cajadeArenaButton.interactable = false;
        }
        else
        {
            cajadeArenaButton.image.color = Color.white;
            cajadeArenaButton.interactable = true;
        }
        if (globalvariables.crystalCount < 550)
        {
            plantitaButton.image.color = Color.gray;
            plantitaButton.interactable = false;
        }
        else
        {
            plantitaButton.image.color = Color.white;
            plantitaButton.interactable = true;
        }
        if (globalvariables.crystalCount < 620)
        {
            iluminationButton.image.color = Color.gray;
            iluminationButton.interactable = false;
        }
        else
        {
            iluminationButton.image.color = Color.white;
            iluminationButton.interactable = true;
        }*/
    }
    public void cajadearenacristalizada() {

        if (globalvariables.crystalCount > 240)
        {
            globalvariables.crystalCount = globalvariables.crystalCount - 240;           
            cajaArena.SetActive(true);
            globalvariables.caja_de_arena_cristalizada = true;
        }
        
    }
    public void plantita()
    {

        if (globalvariables.crystalCount > 550)
        {
            globalvariables.crystalCount = globalvariables.crystalCount - 550;
            flor.SetActive(true);
            globalvariables.plantita_con_escafandra = true;
        }
    }
    public void lamparaMetodo()
    {

        if (globalvariables.crystalCount > 600)
        {
            globalvariables.crystalCount = globalvariables.crystalCount - 600;
            //globalvariables.caja_de_arena_cristalizada = true;
            lampara.SetActive(true);
            globalvariables.ilumination = true;


        }
    }
    public void ilumination()
    {

        if (globalvariables.crystalCount > 620)
        {
            globalvariables.crystalCount = globalvariables.crystalCount - 620;
            //globalvariables.ilumination = true; //ESTO ES UN BOOLEANO EN GLOBAL VARIABLES
            //y no lo queremos usar, queremos spawnear el objeto de una.
            
        }
    }

    public void conditionparte1() {
        if (globalvariables.crystalCount > 580)
        {
            globalvariables.crystalCount = globalvariables.crystalCount - 580;
            globalvariables.PiezaRadio1 = true;

        }
        parte1.image.color = Color.green;
        parte2.image.color = Color.white;

    }
    public void conditionparte2()
    {
        if (globalvariables.PiezaRadio1 == true)
        {
            if (globalvariables.crystalCount > 800)
            {
                globalvariables.crystalCount = globalvariables.crystalCount - 800;
                globalvariables.PiezaRadio2 = true;

            }
            parte2.image.color = Color.green;
            parte3.image.color = Color.white;
        }
    }
    public void conditionparte3()
    {
        if (globalvariables.PiezaRadio2 == true)
        {
            if (globalvariables.crystalCount > 2000)
            {
                globalvariables.crystalCount = globalvariables.crystalCount - 2000;
                globalvariables.PiezaRadio3 = true;

            }
            parte3.image.color = Color.green;
        }  
    }
}
