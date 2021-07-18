using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{


    void Update()
    {
        transform.Rotate(new Vector3(0, 20, 10) * Time.deltaTime);
    }
}
