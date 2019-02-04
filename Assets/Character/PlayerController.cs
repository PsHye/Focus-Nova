using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[Header("Herramientas")]
	public GameObject Pico;
	public float PicoDelay = 1f;//Para que desactive el pico.

	
	[Header("Controller")]
	public float velocidadCaminar;
	public float velocidadRotar;
    public bool inside;

    [Header("Particula y donde spawnear")]
    public ParticleSystem particulaAlTocarCristal;
    public Transform dondeSpawnearPart;
    
	//Componentes
	Animator anim;

    void Start () 
	{
		anim = GetComponent<Animator>();
        Pico.SetActive(false);
        PicoDelay = Mathf.Clamp(0,0,1);
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


        /*if(Pico.activeSelf)
		{
			PicoDelay -= Time.deltaTime;  // De esta forma ahora solo te deja picar si respeta el delay del pico (1 seg)
                                         // Antes entraba cada vez que tocabas space y spawneaba bocha de particulas
                                        // - bran
		}*/

        if (PicoDelay >= 0)
		{
            PicoDelay -= Time.deltaTime; 
        }
		else
		{
            Pico.SetActive(false);
        }

    }

	void OnTriggerStay(Collider otro)
	{
		if(otro.transform.CompareTag("crystal"))
		{
			if(Input.GetKeyDown(KeyCode.Space) && !Pico.activeSelf) //solo si esta desactivado podemos hacer todo esto - bran
			{
                //otro.transform.LookAt(transform.position);
                //transform.LookAt(new Vector3(otro.transform.position.x, otro.transform.position.y, 0));

                Pico.SetActive(true);
                otro.GetComponent<CrystalScript>().Cantidad -= 10;
				anim.SetTrigger("Picaso");
                
                particulaAlTocarCristal.transform.position = dondeSpawnearPart.position; //Play de particulas
                particulaAlTocarCristal.Play();    
				PicoDelay = 1;

                globalvariables.crystalCount += 10;
            }
			
		}
	}
}
