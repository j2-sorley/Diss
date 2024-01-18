using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightAtt : MonoBehaviour
{

    public Light light; 
    // Start is called before the first frame update
    void Start()
    {
        light.intensity = Random.Range(0.0f, 1.0f);
        light.color = Random.ColorHSV(0f, 1f, 1f,1f,0.5f,1f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
