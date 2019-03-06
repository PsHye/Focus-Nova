using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuFunc : MonoBehaviour
{
    public GameObject Shop;
    public GameObject Factory_1;
    public GameObject Factory_2;
    //public GameObject Factory_3;
    public bool puedeMoverse;
    

    bool puedeComprar;
    void Start() {
        puedeComprar = false;
    }

    private void Update()
    {
        if (!Factory_1.activeSelf)
        {
            GetComponent<PlayerController>().enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("factory"))
        {
            Factory_1.SetActive(true);
            GetComponent<PlayerController>().enabled = false;
        }
    }

    /*private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("factory"))
        {
           player.GetComponent<PlayerController>().enabled = true;
        }
    }*/
}
