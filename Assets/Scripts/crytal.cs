using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crytal : MonoBehaviour
{
    public int Cantidad = 500;//cambiar a 160

    void Update()
    {

        switch (Cantidad)
        {
            case 500://cambiar a 160
                transform.localScale = new Vector3(4f, 4f, 4f);
                break;
            case 120:
                transform.localScale = new Vector3(3f, 3f, 3f);
                break;
            case 80:
                transform.localScale = new Vector3(2f, 2f, 2f);
                break;
            case 30:
                transform.localScale = new Vector3(1f, 1f, 1f);
                break;
            case 0:
                Destroy(gameObject);
                break;

        }


    }
}
