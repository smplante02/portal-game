using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour {

    public float delay;
    public float minIntensity;
    public float maxIntensity;
    public bool startAtMin;
    private Light myLight;
    private float timeElapsed;

    private void Awake()
    {
        myLight = GetComponent<Light>();

        if(myLight != null)
        {
            myLight.intensity = startAtMin ? minIntensity : maxIntensity;
        }

    }

    private void Update()
    {
        if (myLight != null)
        {
            timeElapsed += Time.deltaTime;
            if (timeElapsed >= delay)
            {
                timeElapsed = 0;
                ToggleLight();
            }
        }
    }

    private void ToggleLight()
    {
        if (myLight != null)
        {
            if (myLight.intensity == minIntensity)
            {
                myLight.intensity = maxIntensity;
            }

            else if (myLight.intensity == maxIntensity)
            {
                myLight.intensity = minIntensity;
            }
        }
    }
}
