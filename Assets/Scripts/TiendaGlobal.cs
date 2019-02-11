using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiendaGlobal : MonoBehaviour
{

    //Objetos
    [HideInInspector]
    public bool cama = false;
    [HideInInspector]
    public bool flor = false;
    [HideInInspector]
    public bool ilumination = false;

    //Variables Radio.
    [HideInInspector]
    public bool PiezaRadio1 = false;
    [HideInInspector]                       
    public bool PiezaRadio2 = false;       
    [HideInInspector]
    public bool PiezaRadio3 = false;
    
    public static TiendaGlobal INS;
    
    void Start()
    {
        INS = this;
    }
}
