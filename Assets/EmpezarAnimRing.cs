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
        anim.SetBool("HizoTriggerExit", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("HizoTriggerEnter", true);
            anim.SetBool("HizoTriggerExit", false);
        } 
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("HizoTriggerEnter", false);
            anim.SetBool("HizoTriggerExit", true);
        }
    }
}
