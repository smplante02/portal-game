using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endlevel : MonoBehaviour
{
   
    public string sceneName;

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag=="Door")
        {

            SceneManager.LoadScene(sceneName);
        }


    }
}
