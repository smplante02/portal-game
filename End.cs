using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class end : MonoBehaviour {

    public string sceneName;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(sceneName);
    }
}
