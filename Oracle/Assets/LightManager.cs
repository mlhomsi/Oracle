using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LightManager : MonoBehaviour
{
    public NavMeshAgent Player;
    public NavMeshSurface Surface;

    public Transform Destination;


    public GameObject FOV;
    public GameObject Nani;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LightsOff()
    {
        this.GetComponent<Light>().intensity = 0.2f;
        FOV.SetActive(false);
        Nani.SetActive(true);
        Player.SetDestination(Destination.position);
    }

}
