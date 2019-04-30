using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLookAt : MonoBehaviour
{
    public GameObject go;
    public GameObject cam;
    private void Start()
    {
        cam = GameObject.Find("Camera");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (go == null)
        {
            go = this.gameObject;
        }

        go.transform.parent.LookAt(cam.transform);
        
    }
}
