using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class AIcontroller : MonoBehaviour
{
    NavMeshAgent Agent;

    public GameObject Path;

    public string Estado;

    public Animator anim;

    [Header("Patrullando")]

    [Header("Estados")]

    
    public int currentPath;

    public float distancia;

    public float distanciaMax;

    public float tiempoDeEspera;
    float time;

    [Header("Persiguiendo")]

    public GameObject player;
    public float distanciaObjetivo;
    public float distanciaMaxObjetivo;

    void Start()
    {
        time = tiempoDeEspera;
        Agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    void Update()
    {
        var Camino = Path.GetComponent<Pathview>();


        anim.SetFloat("Velocidad", Agent.velocity.magnitude);

        switch(Estado)
        {
            case "Patrullando":
            {
             
            
              
            distancia = Vector3.Distance(transform.position, Camino.Path[currentPath].transform.position);

            Agent.SetDestination(Camino.Path[currentPath].transform.position);


            if (distancia <= distanciaMax)
            {

                tiempoDeEspera -= Time.deltaTime;

                if (tiempoDeEspera <= 0)
                {
                currentPath = currentPath + 1;
                tiempoDeEspera = time; 
                }
            
            }


            if (currentPath >= Camino.Path.Length)
            {
            currentPath = 0;
            }
            break;
            }

            case "Persiguiendo":
            {

            distanciaObjetivo = Vector3.Distance(transform.position, player.transform.position);
            
            if(distanciaObjetivo >= distanciaMaxObjetivo)
            {
             Agent.SetDestination(player.transform.position);            
            }
            else
            {
            Agent.SetDestination(transform.position);
            }
            break;
            }
        }
    }
}
