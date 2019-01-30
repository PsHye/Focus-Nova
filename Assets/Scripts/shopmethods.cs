using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopmethods : MonoBehaviour
{
    public static int Casco;
    public static int Botas;

    public void Start() {
        Casco = 0;
        Botas = 0;

    }
    
    public void mejoraCasco() {

        if (globalvariables.crystalCount > 80 * Casco * Casco && Casco < 5)
        {  

            Casco++;
            globalvariables.crystalCount = globalvariables.crystalCount - (80 * Casco * Casco);
            Debug.Log("Cristales = " + globalvariables.crystalCount);

            Debug.Log("Aire = " + globalvariables.aireRestante);
            globalvariables.aireRestante = globalvariables.aireRestante + 20;
            
            Debug.Log("Aire = " + globalvariables.aireRestante);




        }
    }
    /*public void mejoraBotas()
    {
        if (globalvariables.crystalCount > 40 * Botas * Botas && Botas < 5)
        {
            Botas++;
            playermovement.velocidad = playermovement.velocidad + 0.15f;
            Debug.Log("VELOCIDAD: " + playermovement.velocidad);

            Debug.Log("CRISTALES: " + globalvariables.crystalCount);
            globalvariables.crystalCount = globalvariables.crystalCount - (40 * Botas * Botas);
            Debug.Log("CRISTALES: " + globalvariables.crystalCount);
           

            
        }
       
    }*/

}
