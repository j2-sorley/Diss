using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightAtt : MonoBehaviour
{

    public Light light;
    public Color[] colors;
    public Color set;
    
    public float Intesity; 
    public bool randomColor;
    public bool setColor;
    public bool randomIntensity; 
   
    // Start is called before the first frame update
    void Start()
    {
        
        if (randomColor) {light.color = Random.ColorHSV(0f, 1f, 1f,1f,0.5f,1f);}
        if (setColor) { light.color = set; light.intensity = Intesity;}
        if (randomIntensity) { light.intensity = Random.Range(0.0f, 1.0f); }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
