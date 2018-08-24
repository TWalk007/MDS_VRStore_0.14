using UnityEngine;

public class HighlightController_Rinse : MonoBehaviour {

    private GameObject bottle;
    private Transform bottleTrans;

    public bool objectInHand = false;

    public Material[] materials = new Material[2];

    private void Start()
    {
        bottleTrans = gameObject.transform.Find("Rinse_02");
        bottle = bottleTrans.gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Controller (left)" || other.gameObject.name == "Controller (right)")
        {
            if (!objectInHand)
            {
                bottle.GetComponent<Renderer>().material = materials[1];
            }
            else
            {
                bottle.GetComponent<Renderer>().material = materials[0];
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Controller (left)" || other.gameObject.name == "Controller (right)")
        {
            if (objectInHand)
            {
                bottle.GetComponent<Renderer>().material = materials[0];
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Controller (left)" || other.gameObject.name == "Controller (right)")
        {
            bottle.GetComponent<Renderer>().material = materials[0];
        }
    }
}
