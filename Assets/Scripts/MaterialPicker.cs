using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialPicker : MonoBehaviour
{

    public Renderer render;
    public Material[] mats; 
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
        int i = Random.Range(0,mats.Length);

        render.material = mats[i];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
