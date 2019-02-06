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
    public ParticleSystem particulaNumeroDeGolpe;
    public ParticleSystem particulaAtaqueCristal;

    public Transform dondeSpawnearPart;
    public Transform prueba; // si ves esto es por que no lo borre, borralo
                             // tmb borrar el gameobject Prueba que esta abajo del pico
    [Header("Camera Shake")]
    public CamaraShakeBran camaraShake;
    [Range(0, 0.5f)]
    public float tiempoShake = 0.0f;
    [Range(0, 0.2f)]
    public float fuerzaShake = 0.0f;

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


        if (PicoDelay >= 0)
		{
            PicoDelay -= Time.deltaTime; 
        }
		else
		{
            Pico.SetActive(false);
        }
        if (Input.GetKeyDown("space"))
        {
            particulaAtaqueCristal.transform.position = prueba.position;
            particulaAtaqueCristal.transform.rotation = transform.rotation;
            particulaAtaqueCristal.Play();
            StartCoroutine(camaraShake.Shake(tiempoShake, fuerzaShake));
        }
    }

	void OnTriggerStay(Collider otro)
	{
		if(otro.transform.CompareTag("crystal"))
		{
			if(Input.GetKeyDown(KeyCode.Space) && !Pico.activeSelf) //solo si esta desactivado podemos hacer todo esto - bran
			{
                Pico.SetActive(true);
                otro.GetComponent<CrystalScript>().Cantidad -= 10;
				anim.SetTrigger("Picaso");
                
                particulaAlTocarCristal.transform.position = dondeSpawnearPart.position; //Play de particulas del golpe
                particulaAlTocarCristal.Play();
                particulaNumeroDeGolpe.transform.position = dondeSpawnearPart.position; //Play de particulas del numero del golpe
                particulaNumeroDeGolpe.Play();
                PicoDelay = 1;

                globalvariables.crystalCount += 10;
            }
			
		}
	}
}
