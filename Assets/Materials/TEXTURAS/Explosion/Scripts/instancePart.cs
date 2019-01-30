using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instancePart : MonoBehaviour {

    public Explosion pepe;
    GameObject instance;
    void Start () {
        instance = GameObject.CreatePrimitive(PrimitiveType.Cube);
        instance.SetActive(false);
        instance.transform.localScale = new Vector3(2.5f,2.5f,2.5f);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            pepe.Play();
            instance.SetActive(true);
        }
	}
}
