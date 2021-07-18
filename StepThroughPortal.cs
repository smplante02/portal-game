using UnityEngine;
using System.Collections;

public class StepThroughPortal : MonoBehaviour
{

    public GameObject otherPortal;
   

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("something hit the portal");
        if (other.tag == "Player" || other.tag == "Cube")
        {
            other.transform.position = otherPortal.transform.position + otherPortal.transform.forward * 2;
            other.transform.rotation = otherPortal.transform.rotation;

        }
        

    }
}