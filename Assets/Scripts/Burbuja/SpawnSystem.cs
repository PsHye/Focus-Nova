using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour {

	// Use this for initialization
	public Transform[] spawnPoints;

	public GameObject Objeto;

    public float max;
    public float min;


	float caca;
	void Start () 
	{

		caca = Random.Range(min,max);
		
	}
	

	void Update () 
	{
		
		caca -= Time.deltaTime;
		if(caca <= 0)
		{
			Instantiate(Objeto, spawnPoints[Random.Range(0,spawnPoints.Length)]);
            caca = Random.Range(min, max);
		}


	}
}
