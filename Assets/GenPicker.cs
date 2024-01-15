using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenPicker : MonoBehaviour
{
    public GameObject[] Gens;
    public int Picker; 
    // Start is called before the first frame update
    void Start()
    {
        Picker = Random.Range(0, Gens.Length);
        Gens[Picker].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
