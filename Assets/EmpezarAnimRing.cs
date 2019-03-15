using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpezarAnimRing : MonoBehaviour
{
    Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("HizoTriggerEnter", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("HizoTriggerEnter", true);
        } 
    }
}
