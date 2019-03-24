using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIvision : MonoBehaviour
{
    public AIcontroller master;
    public float distancaDeVista;
    public Vector3 Offset;
    public LayerMask layermask;
    RaycastHit hit;
    Vector3 direccion;

    public bool viendo;

    private void Update()
    {
        if (viendo)
        {
            direccion = master.player.transform.position - transform.position;

            
            if (Physics.Raycast(transform.position, direccion + Offset, out hit, distancaDeVista, layermask))
            {
                master.Estado = "Persiguiendo";
                Debug.Log("Te vi culiao xD");
                /*if (hit.transform.CompareTag("Player"))
                {
                    master.Estado = "Persiguiendo";
                    Debug.Log("Te vi culiao xD");
                }*/
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            viendo = true;
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            viendo = false;
        }
    }

    void OnDrawGizmos()
    {
        if(viendo)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, hit.point);
            Gizmos.DrawSphere(hit.point, 0.5f);
        }
        
    }
}
