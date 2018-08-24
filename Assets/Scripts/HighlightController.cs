using UnityEngine;

public class HighlightController : MonoBehaviour {

    public Material[] materials = new Material[2];

    public bool objectInHand = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Controller (left)" || other.gameObject.name == "Controller (right)")
        {
            if (!objectInHand)
            {
                GetComponent<Renderer>().material = materials[1];
            }
            else
            {
                GetComponent<Renderer>().material = materials[0];
            }            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Controller (left)" || other.gameObject.name == "Controller (right)")
        {
            if (objectInHand)
            {
                GetComponent<Renderer>().material = materials[0];
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Controller (left)" || other.gameObject.name == "Controller (right)")
        {
            GetComponent<Renderer>().material = materials[0];
        }
    }
  }
