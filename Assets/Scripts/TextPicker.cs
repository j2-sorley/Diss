using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class TextPicker : MonoBehaviour
{

    public TMP_Text textMeshPro;
     
    
    // Start is called before the first frame update
    void Start()
    {
        string[] title = System.IO.File.ReadAllLines("titles.txt"); 
        int R = Random.Range(0, title.Length);
        textMeshPro.SetText(title[R]); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
