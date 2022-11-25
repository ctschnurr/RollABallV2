using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDisabler : MonoBehaviour
{
    public Camera myCamera; 

    // Start is called before the first frame update
    void Start()
    {
        myCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            myCamera.enabled = false;

        }
    }
}
