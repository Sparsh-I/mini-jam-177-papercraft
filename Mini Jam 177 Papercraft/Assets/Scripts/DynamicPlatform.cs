using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicPlatform : MonoBehaviour
{
    public bool togglePlatform;
    
    // Update is called once per frame
    void Update()
    {
        if (togglePlatform)
            gameObject.SetActive(true);
    }
}
