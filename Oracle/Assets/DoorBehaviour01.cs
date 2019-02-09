using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DoorBehaviour01 : MonoBehaviour
{
    public NavMeshAgent Player;
    public Transform destination;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level01()
    {
        Player.SetDestination(destination.position);

    }
}
