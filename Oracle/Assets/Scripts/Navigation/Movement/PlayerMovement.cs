using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerMovement : MonoBehaviour
{
    public Camera Cam;
    public NavMeshAgent Agent;

   // public ThirdPersonCharacter Char;

    private void Start()
    {
      //  Agent.updateRotation = false;
    }

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

        if(Agent.remainingDistance > Agent.stoppingDistance)
        {
           // Char.Move(Agent.desiredVelocity, false, false);
        }
       // else Char.Move(Vector3.zero, false, false);

    }
}
