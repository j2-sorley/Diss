using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightAtt : MonoBehaviour
{

    public Light light;
    public Color[] colors;
    private Color set;
    public bool randomColor;
    public bool setColor;
    public bool randomIntensity; 
   
    // Start is called before the first frame update
    void Start()
    {
        set = colors[Random.Range(0, colors.Length)]; 
        if (randomColor) {light.color = Random.ColorHSV(0f, 1f, 1f,1f,0.5f,1f);}
        if (setColor) { light.color = set; }
        if (randomIntensity) { light.intensity = Random.Range(0.0f, 1.0f); }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
