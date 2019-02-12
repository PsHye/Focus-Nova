using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class factorymethods : MonoBehaviour{

    public Button parte1;
    public Button parte2;
    public Button parte3;
    public Button cajadeArenaButton;
    public Button plantitaButton;
    public Button iluminationButton;
    
    void Update() {
            #region ComentarioNico
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
            #endregion
    }

    public void cajadearenacristalizada() {

        if (globalvariables.crystalCount > 1) //240)
        {
            globalvariables.crystalCount -= 1; //240;         
            TiendaGlobal.INS.cama = true;
            cajadeArenaButton.gameObject.GetComponent<Button>().enabled = false;
        }
    }

    public void plantita()
    {
        if (globalvariables.crystalCount > 1) //240)
        {
            globalvariables.crystalCount -= 1; //240;
            TiendaGlobal.INS.flor = true;
            plantitaButton.gameObject.GetComponent<Button>().enabled = false;
        }
    }
    
    public void ilumination()
    {
        if (globalvariables.crystalCount > 1) //240)
        {
            globalvariables.crystalCount -= 1; //240;
            TiendaGlobal.INS.ilumination = true; //ESTO ES UN BOOLEANO EN GLOBAL VARIABLES
            iluminationButton.gameObject.GetComponent<Button>().enabled = false;
        }
    }

    public void conditionparte1() {
        if (globalvariables.crystalCount > 1) //500
        {
            globalvariables.crystalCount -= 1;
            TiendaGlobal.INS.PiezaRadio1 = true;
            parte1.gameObject.GetComponent<Button>().enabled = false;
        }
        parte1.image.color = Color.green;
        parte2.image.color = Color.white;
    }

    public void conditionparte2()
    {
        if (TiendaGlobal.INS.PiezaRadio1 && globalvariables.crystalCount > 2) //800
        {
            globalvariables.crystalCount -= 1; //800
            TiendaGlobal.INS.PiezaRadio2 = true;
            parte2.image.color = Color.green;
            parte3.image.color = Color.white;
            parte2.gameObject.GetComponent<Button>().enabled = false;
        }
    }

    public void conditionparte3()
    {
        if (TiendaGlobal.INS.PiezaRadio2 && globalvariables.crystalCount > 2) //2000
        {
            globalvariables.crystalCount -= 2000;
            TiendaGlobal.INS.PiezaRadio3 = true;
            parte3.image.color = Color.green;
            parte3.gameObject.GetComponent<Button>().enabled = false;
        }  
    }
}
