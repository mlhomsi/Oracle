using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SceneController : MonoBehaviour
{

    public NavMeshAgent Agent;
    public NavMeshSurface Surface;

    public Transform Destination;
    public Animator DoorAnimation;

    public Transform WinTransform;
    public float waitTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Agent.SetDestination(Destination.position);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        Agent.SetDestination(WinTransform.position);

    }

    public void OpenDoor01()
    {
        DoorAnimation.SetTrigger("OpenDoor");
        StartCoroutine(Wait());

    }
}
