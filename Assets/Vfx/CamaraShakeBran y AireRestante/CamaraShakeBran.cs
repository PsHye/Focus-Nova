using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraShakeBran : MonoBehaviour
{
    public IEnumerator Shake(float duracion, float fuerza)
    {
        Vector3 posOriginal = transform.localPosition;

        float transcurrido = 0.0f;

        while (transcurrido < duracion)
        {
            float x = Random.Range(-1.5f, 1.5f) * fuerza;
            float y = Random.Range(-1f, 1f) * fuerza;
                                        //aca abajo antes era solo X e Y, eso me snappeaba la camara a la posicion que tirara el range..
                                       //..en vez de moverla un poquito, gracias por nada Brackeys
            transform.localPosition = new Vector3(posOriginal.x + x, posOriginal.y + y, posOriginal.z);

            transcurrido += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = posOriginal;
    }
}
