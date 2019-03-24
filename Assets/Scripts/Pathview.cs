using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Pathview : MonoBehaviour
{
   public Transform[] Path;

    public Color Preview;
    public float Radio;
   void OnDrawGizmos()
    {
        Gizmos.color = Preview;
        for (int i = 0; i < Path.Length; i++)
        {
           Gizmos.DrawLine(Path[i].transform.position, Path[i + 1].transform.position);
           Gizmos.DrawSphere(Path[i].transform.position, Radio);
         
        }      
    }
}
