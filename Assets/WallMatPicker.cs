using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMatPicker : MonoBehaviour
{
    public Renderer[] Walls;
    public Material[] Mats; 
    void Start()
    {
        int i = Random.Range(0, Mats.Length);

        for (int j = 0; j < Mats.Length+1; j++) {Walls[j].material = Mats[i]; }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
