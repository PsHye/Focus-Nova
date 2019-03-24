using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerIK : MonoBehaviour
{
    Animator Anim;

    public float pieWeight;


    
    public bool UseIk;

    public Transform PieIIk;
    public Transform PieDIk;


    Vector3 PieIPos;
    Vector3 PieDPos;

    Quaternion PieIRot;
    Quaternion PieDRot;

    RaycastHit PI;
    RaycastHit PD;


    void Start()
    {
        Anim = GetComponent<Animator>();

    }

    void OnAnimatorIK()
    {
        
        if (UseIk)
        {
            Anim.SetIKPositionWeight(AvatarIKGoal.RightFoot, 1);
            Anim.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 1);

            Anim.SetIKRotationWeight(AvatarIKGoal.RightFoot, 1);
            Anim.SetIKRotationWeight(AvatarIKGoal.LeftFoot, 1);

            Anim.SetIKPosition(AvatarIKGoal.RightFoot, PieDPos);
            Anim.SetIKRotation(AvatarIKGoal.RightFoot, PieDRot);

            Anim.SetIKPosition(AvatarIKGoal.LeftFoot, PieIPos);
            Anim.SetIKRotation(AvatarIKGoal.LeftFoot, PieIRot);




        }
        else
        {
            Anim.SetIKPositionWeight(AvatarIKGoal.RightFoot, 0);
            Anim.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 0);

            Anim.SetIKRotationWeight(AvatarIKGoal.RightFoot, 0);
            Anim.SetIKRotationWeight(AvatarIKGoal.LeftFoot, 0);
        }

     

       

    }

    void FixedUpdate()
    {
        if (UseIk)
        {
            if (Physics.Raycast(PieDIk.position, Vector3.down, out PD))
            {
                PieDPos = PD.point;
                PieDRot = Quaternion.FromToRotation(transform.up, PD.normal) * PieIIk.rotation;
            }

            if (Physics.Raycast(PieIIk.position, Vector3.down, out PI))
            {
                PieIPos = PI.point;
                PieIRot = Quaternion.FromToRotation(transform.up, PI.normal) * PieIIk.rotation;
            }

        }
    }


    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(PieIIk.position, PieDIk.position);
        Gizmos.DrawSphere(PieIIk.position, 0.1f);
        Gizmos.DrawSphere(PieDIk.position, 0.1f);
        Gizmos.DrawLine(PieIIk.position, PI.point);
        Gizmos.DrawLine(PieDIk.position, PD.point);
        Gizmos.DrawSphere(PD.point, 0.1f);
        Gizmos.DrawSphere(PI.point, 0.1f);
    }

}