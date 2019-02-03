using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiendaGlobal : MonoBehaviour
{

    //INVENTARIO*************
    [HideInInspector]
    public bool cama = false;
    public bool flor = false;
    public bool ilumination = false;

    //Variables Radio.
    [HideInInspector]
    public bool PiezaRadio1 = false;     //mover todo esto a otro script global que se relacione con la tienda
    public bool PiezaRadio2 = false;    //hecho
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
