using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiendaGlobal : MonoBehaviour
{

    //INVENTARIO*************
    [HideInInspector]
    public bool cama = false;
    [HideInInspector]
    public bool flor = false;
    [HideInInspector]
    public bool ilumination = false;

    //Variables Radio.
    [HideInInspector]
    public bool PiezaRadio1 = false;
    [HideInInspector]                       //mover todo esto a otro script global que se relacione con la tienda
    public bool PiezaRadio2 = false;       //hecho
    [HideInInspector]
    public bool PiezaRadio3 = false;

    public static TiendaGlobal INS;

    void Start()
    {
        INS = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
