using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shader : MonoBehaviour
{
    public Camera cam;
    public Shader effect; 
    void Start()
    {
        cam.RenderWithShader(effect, "effect"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
