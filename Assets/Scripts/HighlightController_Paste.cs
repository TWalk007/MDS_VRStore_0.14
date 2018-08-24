using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightController_Paste : MonoBehaviour {

    private GameObject pasteBox;
    private Transform pasteBoxTrans;

    public bool objectInHand = false;

    public Material[] materials = new Material[2];

    private void Start()
    {
        pasteBoxTrans = gameObject.transform.Find("Paste_PH_4.2oz_HealthyClean_01");
        pasteBox = pasteBoxTrans.gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Controller (left)" || other.gameObject.name == "Controller (right)")
        {
            if (!objectInHand)
            {
                pasteBox.GetComponent<Renderer>().material = materials[1];
            }
            else
            {
                pasteBox.GetComponent<Renderer>().material = materials[0];
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Controller (left)" || other.gameObject.name == "Controller (right)")
        {
            if (objectInHand)
            {
                pasteBox.GetComponent<Renderer>().material = materials[0];
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Controller (left)" || other.gameObject.name == "Controller (right)")
        {
            pasteBox.GetComponent<Renderer>().material = materials[0];
        }
    }
}
