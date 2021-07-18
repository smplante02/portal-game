using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressureplate2 : MonoBehaviour
{

    public GameObject DOOR;
    public GameObject DOOR2;
    public GameObject Cube;
    public GameObject Player;


    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Cube")
        {
            Player.GetComponent<PickupObject>().dropObject();
            Destroy(DOOR);
            Destroy(DOOR2);
            Destroy(Cube);


        }


    }
}
