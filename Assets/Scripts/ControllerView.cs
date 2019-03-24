using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ControllerView : MonoBehaviour
{

    [Header("Gizmos")]
    public float Radio;

    public bool Camara;
    float damping;
    Vector3 Rotation;
    Quaternion rotation;



   /* void OnDrawGizmos()
    {
        //Y
        Handles.color = Color.white;
        Handles.DrawWireDisc(transform.position, Vector3.up, Radio);
        //Z
        Handles.color = Color.blue;
        Handles.DrawArrow(0, transform.position, Quaternion.LookRotation(transform.forward), Radio);
        //X
        Handles.color = Color.red;
        Handles.DrawArrow(0, transform.position, Quaternion.LookRotation(transform.right), Radio);

        //Camera
        if(Camara)
        {
            Rotation = Camera.main.transform.position - transform.position;

            rotation = Quaternion.LookRotation(Rotation, Vector3.up);
            rotation.x = 0; rotation.z = 0;

            Handles.color = Color.white;
            Handles.DrawArrow(0, transform.position, rotation, Radio);
        }
   
    }*/
}
