using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraInterior : MonoBehaviour
{
    public GameObject player;
    //public Vector3 posicionPlayer;    
    public float y;
    public float x;
    public float z;
    public float dureza;
    public float limitacionH;
    public float limitacionP;
    float posicionRelativaZ = 0;
    float posicionRelativaX = 0;
    Vector3 posicionPlayerResultante;
    // Use this for initialization
    void Start()    {        
       
    }

    // Update is called once per frame
    void Update()
    {

        //posicionPlayer = new Vector3(player.transform.position.x, player.transform.position.y + y, player.transform.position.z + z);
        posicionRelativaZ = player.transform.position.z - z;
        posicionRelativaX = player.transform.position.x - x;
        posicionPlayerResultante = new Vector3(player.transform.position.x - (posicionRelativaX / limitacionP), player.transform.position.y + y, player.transform.position.z - (posicionRelativaZ / limitacionH));
        //transform.position = new Vector3(posicionPlayer.x/1.15f,posicionPlayer.y+y, posicionPlayer.z-z);
        transform.position = Vector3.Lerp(transform.position, posicionPlayerResultante, dureza * Time.deltaTime);






    }
}
