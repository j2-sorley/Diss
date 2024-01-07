using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterArrayPicker : MonoBehaviour
{
    public Renderer render;
    public Renderer render2; 
    public Material[] mats;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
        render2 = GetComponent<Renderer>(); 
        int i = Random.Range(0, mats.Length);

        render.material = mats[i];
        render2.material = mats[i];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
