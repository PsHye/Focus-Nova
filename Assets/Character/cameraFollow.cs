using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

    public GameObject player;
    //public Vector3 posicionPlayer;
    //private Vector3 posicionCamera;
    public float y;
    public float x;
    public float z;
    public float dureza;
    float posicionRelativaX = 0;
    Vector3 posicionPlayerResultante;
	// Use this for initialization
	void Start () {
        
        dureza = 5;
	}
	
	// Update is called once per frame
	void Update () {
        //posicionCamera = transform.position;
        //posicionPlayer = new Vector3(player.transform.position.x, player.transform.position.y + y, player.transform.position.z + z);
        posicionRelativaX = player.transform.position.z - z;        
        posicionPlayerResultante = new Vector3(player.transform.position.x + x, player.transform.position.y + y, player.transform.position.z - (posicionRelativaX / 2.5f));
        //transform.position = new Vector3(posicionPlayer.x/1.15f,posicionPlayer.y+y, posicionPlayer.z-z);
        transform.position = Vector3.Lerp(transform.position, posicionPlayerResultante, dureza * Time.deltaTime);


	}
}
