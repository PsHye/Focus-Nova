using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instancePart : MonoBehaviour {

    public Explosion pepe;

    public Transform insUno;
    public Transform insDos;
    public Transform insTres;
    public Transform insCuatro;

    void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            pepe.transform.position = insUno.position;
            pepe.Play();
            /*instance = GameObject.CreatePrimitive(PrimitiveType.Cube);
            instance.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
            instance.transform.position = insUno.position;*/
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            pepe.transform.position = insDos.position;
            pepe.Play();
            /*instance = GameObject.CreatePrimitive(PrimitiveType.Cube);
            instance.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
            instance.transform.position = insDos.position;*/
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            pepe.transform.position = insTres.position;
            pepe.Play();
            /*instance = GameObject.CreatePrimitive(PrimitiveType.Cube);
            instance.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
            instance.transform.position = insTres.position;*/
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            pepe.transform.position = insCuatro.position;
            pepe.Play();
            /*instance = GameObject.CreatePrimitive(PrimitiveType.Cube);
            instance.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
            instance.transform.position = insCuatro.position;*/
        }
    }
}
