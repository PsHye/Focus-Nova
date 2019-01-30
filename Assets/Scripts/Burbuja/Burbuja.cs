using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burbuja : MonoBehaviour {

    Rigidbody rb;

    MeshRenderer _mrender;
    public int azar;

    public float Valor;

    public AudioSource _bexplosionA;
    public AudioSource _bexplosionB;

    float _dtime = 5f;
    public bool destruir;
    float tiempo;

    void Start()
    {
        azar = Random.Range(1, 2);
        _mrender = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        rb.AddForce(new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f)));

        tiempo = Random.Range(15f, 20f);
    }

    void Update()
    {
        tiempo -= Time.deltaTime;
        if (tiempo <= 0)
        {
            Explosion();
        }

        if (destruir)
        {
            _dtime -= Time.deltaTime;
            if (_dtime <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Player")
        {
            globalvariables.aireRestante += Valor;
            Explosion();
        }
        Explosion();

    }


    void Explosion()
    {

        if (azar == 1)
        {
            _bexplosionA.Play();
            _mrender.enabled = false;
            destruir = true;
        }
        if (azar == 2)
        {
            _bexplosionB.Play();
            _mrender.enabled = false;
            destruir = true;

        }

    }

}
