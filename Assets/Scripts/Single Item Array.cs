using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleItemArray : MonoBehaviour
{

    public GameObject[] Items;
    public Transform tr; 
    int i; 


    // Start is called before the first frame update
    void Start()
    {
        i = Random.Range(0, Items.Length);
        Instantiate(Items[i], tr.position, tr.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
