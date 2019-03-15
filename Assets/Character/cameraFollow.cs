using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

    public GameObject player;
    public float y;
    public float x;
    public float z;
    public float dureza;
    float posicionRelativaX = 0;
    Vector3 posicionPlayerResultante;
    public GameObject camaraBloom;

    void Start () {
        dureza = 5;
        //Invoke("ActivaLaCam", 2f);
	}
	
	void Update () {
        posicionRelativaX = player.transform.position.z - z;        
        posicionPlayerResultante = new Vector3(player.transform.position.x + x, player.transform.position.y + y, player.transform.position.z - (posicionRelativaX / 2.5f));
        transform.position = Vector3.Lerp(transform.position, posicionPlayerResultante, dureza * Time.deltaTime);
    }

    /*void ActivaLaCam()
    {
        print("LA CONCHA DE TU MADRE ALL BOYS FUNCIONÁ");
        camaraBloom.SetActive(true);
    }*/
}
