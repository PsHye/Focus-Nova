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
    private bool isActive;
    public bool puedeMoverse;

    bool puedeComprar;
    void Start() {
        puedeComprar = false;
    }

    void Update()
    {
        if (Input.GetKeyDown("p") && puedeComprar)
        {
            Factory_1.SetActive(true);
            
        }
        if (Factory_1.activeSelf && !puedeComprar)
        {
            Factory_1.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("factory"))
        {
            puedeComprar = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("factory"))
        {
            puedeComprar = false;
        }
    }
}
