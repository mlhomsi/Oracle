using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOV : MonoBehaviour
{
    public GameObject player;
    private Transform Startposition;

    // Start is called before the first frame update
    void Start()
    {
        Startposition = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            player.transform.position = Startposition.position;
        }
    }
}
