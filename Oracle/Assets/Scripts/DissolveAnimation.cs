using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class DissolveAnimation : MonoBehaviour
{
    public GameObject ThisDoor; //This Object

    public bool IsDissolving = false; // Vanish Trigger
    public Material Door; //Material with the Vanish Shader
    private float CurrentStage;

    public NavMeshSurface Surface;
    



    private void Start()
    {
        //Set variable "Stage Of Dissolve" to -0,1f, it´s minimum value;
        Door.SetFloat("Vector1_5658DA2C", -0.1f);
    }
    void Update()
    {
        //Get the current Stage Of Dissolve; if greater than 0.5f, disables the object´s collider;
        CurrentStage = Door.GetFloat(("Vector1_5658DA2C"));
        if (CurrentStage >= 0.5f)
        {
            ThisDoor.GetComponent<BoxCollider>().enabled = false;
            ThisDoor.layer = 8;
            Surface.BuildNavMesh();
        }

        if(IsDissolving)
        {
            StartCoroutine(Dissolve());
        }
    }
    public void TriggerDissolve()
    {
        IsDissolving = true;
        StartCoroutine(Dissolve());
    }
    IEnumerator Dissolve()
    {
        for (float f = 0f; f <= 1.1f; f += 0.01f)
        {
            {
                Door.SetFloat("Vector1_5658DA2C", f);
                //Debug.Log(f);
                yield return new WaitForSeconds(0.001f);
            }
        }
    }
    
}
