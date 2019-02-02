using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public Camera Cam;
    public NavMeshAgent Agent;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray Ray = Cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hit;

            if(Physics.Raycast(Ray, out Hit))
            {
                Agent.SetDestination(Hit.point);
            }
        }
    }
}
