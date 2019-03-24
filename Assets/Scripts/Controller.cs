using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [Header("ENTRADAS")]
    public float Horizontal;
    public float Vertical;

    public float velocidad = 3f;

    public Vector3 moveDirection;

    public Vector3 combinedInput;

    RaycastHit hit;

    Rigidbody rb;
    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");


        Vector3 correctedVertical = Vertical * Camera.main.transform.forward;
        Vector3 correctedHorizontal = Horizontal * Camera.main.transform.right;

        combinedInput = new Vector3(correctedHorizontal.x, 0, correctedVertical.z);

        moveDirection = new Vector3((combinedInput).normalized.x, 0, (combinedInput).normalized.z);

        Quaternion rot = Quaternion.LookRotation(moveDirection);

        if (Horizontal != 0 || Vertical != 0)
        {
            transform.rotation = rot;
        }

        

     




    }

    void FixedUpdate()
    {

        rb.velocity = (moveDirection * velocidad);
        anim.SetFloat("V", rb.velocity.magnitude);


    }

 
}
