using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[Header("Herramientas")]
	public GameObject Pico;
	float PicoDelay = 0;//Para que desactive el pico.

	
	[Header("Controller")]
	public float velocidadCaminar;
	public float velocidadRotar;
    public bool inside;



	//Componentes
	Animator anim;


	void Start () 
	{
		anim = GetComponent<Animator>();		
	}
	void Update () 
	{
        var Horizontal = Input.GetAxis("Horizontal");
		var Vertical = Input.GetAxis("Vertical");

		anim.SetFloat("Horizontal", Horizontal);
		anim.SetFloat("Vertical", Vertical);
        anim.SetBool("Inside", inside);

        transform.Translate(new Vector3(0, 0, Vertical) * Time.deltaTime * velocidadCaminar);
		if(Vertical != 0)
		{
			transform.Rotate(new Vector3(0, Horizontal, 0) * velocidadRotar);
		}

		
		if(Pico.activeSelf)
		{
			PicoDelay -= Time.deltaTime;
		}
		if(PicoDelay <= 0)
		{
            Pico.SetActive(false);
        }
		else
		{
			Pico.SetActive(true);
		}

    }

	void OnTriggerStay(Collider otro)
	{
		if(otro.transform.tag == "crystal")
		{
			if(Input.GetKeyDown(KeyCode.Space))
			{

					otro.GetComponent<CrystalScript>().Cantidad = otro.GetComponent<CrystalScript>().Cantidad - 10;
					anim.SetTrigger("Picaso");	
					PicoDelay = 1;
                    globalvariables.crystalCount += 10;
            }
			
		}
	}
}
