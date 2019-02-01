using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarLayerCuarto : MonoBehaviour {

    LayerMask cuartoAVer = (1<<9); //anda a saber como funca esto no?
    //LayerMask cuartoANoVerDeAfuera = (1 << 11);
    Camera cam;
    //public Animator anim;
    public Transform newPos;
    public Transform startPos;

    private void Start()
    {
        cam = Camera.main;
       // anim.SetBool("terminoAnim", true);
    }
    
    //camera.cullingMask = -1; // -1 means "Everything"

    private void OnTriggerStay(Collider other)
    {
        print("asdass");
        if (other.transform.CompareTag("Cuarto"))//&& anim.GetBool("terminoAnim") == true)
        {
            this.GetComponentInParent<PlayerController>().enabled = false;
            //anim.SetTrigger("FadeOut");
            Invoke("Reposicionar", 1f);
            this.gameObject.layer = 10;
            this.transform.DetachChildren();
            //anim.SetBool("terminoAnim", false);
            
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
       // anim.SetTrigger("FadeOut");
        this.GetComponent<PlayerController>().enabled = false;
        Invoke("ReposicionarDos", 1f);
    }

    void Reposicionar()
    {

        //anim.SetTrigger("FadeIn");
        
        #region propiedadesCam
        cam.cullingMask = cuartoAVer;
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = Color.black;
        cam.transform.position = newPos.position;
        cam.transform.rotation = newPos.rotation;
        #endregion

        this.transform.position = new Vector3(-2.28f, 0.15f, 1.598f);
        this.GetComponent<PlayerController>().enabled = true;
    }

    void ReposicionarDos()
    {
        //anim.SetTrigger("FadeIn");
        //anim.SetBool("terminoAnim", true);
        
        #region propiedadesCam
        cam.cullingMask = 1;
        cam.clearFlags = CameraClearFlags.Skybox;
        cam.transform.position = startPos.position;
        cam.transform.rotation = startPos.rotation;
        cam.transform.SetParent(this.transform);
        #endregion

        this.transform.position = new Vector3(-2.28f, 0.15f, 2.548f);
        this.GetComponent<PlayerController>().enabled = true;
    }
}
