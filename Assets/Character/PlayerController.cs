using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [Header("Referencias Cristales")]
    public CrystalScript cristalScript;

    [Header("Herramientas")]
	public GameObject Pico;
	public float PicoDelay = 1f;//Para que desactive el pico.

	
	[Header("Controller")]
	public float velocidadCaminar;
	public float velocidadRotar;
    public bool inside;
    bool puedePicar;
    bool anilloActivar;
    public GameObject anillo;
    public float distanciaMax;
    public float distanciaMin;
    float distanciaVerdadera;

    [Header("Particula y donde spawnear")]
    public ParticleSystem particulaAlTocarCristal;
    public ParticleSystem particulaNumeroDeGolpe;
    public ParticleSystem particulaAtaqueCristal;

    public Transform dondeSpawnearPart;
    public Transform prueba; //aca es donde se va a spawnear la part

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
        puedePicar = false;
        anilloActivar = false;
    }
	void Update () 
	{
        #region MOVIMIENTO_DANI
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
        #endregion MOVIMIENTO_DANI

        if (PicoDelay >= 0)
		{
            PicoDelay -= Time.deltaTime; 
        }
		else
		{
            Pico.SetActive(false);
        }

        if (Input.GetKeyDown("space") && !Pico.activeSelf && puedePicar) //Como spawnear esta particula mas el shake de la camara, dejar aca hasta que temgamos al enemigo listo
        {
            //prueba ataque
            particulaAtaqueCristal.transform.position = prueba.position;
            particulaAtaqueCristal.transform.rotation = transform.rotation;
            particulaAtaqueCristal.Play();
            StartCoroutine(camaraShake.Shake(tiempoShake, fuerzaShake));
            
            //cosas del pico
            Pico.SetActive(true);
            cristalScript.Cantidad -= 10;
            cristalScript.cantidadCristales();
            anim.SetTrigger("Picaso");

            particulaAlTocarCristal.transform.position = dondeSpawnearPart.position; //Play de particulas del golpe
            particulaAlTocarCristal.Play();
            particulaNumeroDeGolpe.transform.position = dondeSpawnearPart.position; //Play de particulas del numero del golpe
            particulaNumeroDeGolpe.Play();
            PicoDelay = 1;
            
            //Crystal contador
            globalvariables.crystalCount += 10;
        }
        if (anilloActivar)
        {
            distanciaVerdadera = Vector3.Distance(this.transform.position, anillo.transform.position);
            if (distanciaVerdadera <= 9f)
            {
                anillo.GetComponent<Renderer>().material.SetFloat("Variante", Mathf.Lerp(0,1,RemapDistancia(distanciaVerdadera,0,1)));
                print(distanciaVerdadera);
            }
        }
    }
    

    private void OnTriggerEnter(Collider other)     //FORMA NUEVA
    {
        if (other.transform.CompareTag("crystal"))
        {
            puedePicar = true;
            cristalScript = other.GetComponent<CrystalScript>();
        }
        if (other.transform.CompareTag("Ring"))
        {
            anilloActivar = true;
            print("asdad");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("crystal"))
        {
            puedePicar = false;
            cristalScript = null;
        }
    }

    float RemapDistancia(float minMaxViejo, float minNuevo, float maxNuevo)
    {
        
        return 0;
    }
}
