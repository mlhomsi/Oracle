using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    public Material Outline;
    public float OutlineThinness = 0.7f;
    //public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        //button.SetActive(false);
        Outline.SetFloat("Vector1_CFE0059", 1.1f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        Outline.SetFloat("Vector1_CFE0059", OutlineThinness);
        //button.SetActive(true);
    }

    private void OnMouseExit()
    {
        Outline.SetFloat("Vector1_CFE0059", 1.1f);
        //button.SetActive(false);

    }
}
