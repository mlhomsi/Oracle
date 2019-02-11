using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hover : MonoBehaviour
{
    public Material Outline;
    public float OutlineThinness = 0.7f;
    public GameObject button;
    public GameObject light;

    //public Button ActionButton;
    

    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(false);
        light.SetActive(false);
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
        //ActionButton.transform.Translate(Input.mousePosition);
        button.SetActive(true);
        light.SetActive(true);

    }

    private void OnMouseExit()
    {
        Outline.SetFloat("Vector1_CFE0059", 1.1f);
        //button.SetActive(false);
        button.SetActive(false);
        light.SetActive(false);


    }
}
