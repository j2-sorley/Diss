using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleItemArray : MonoBehaviour
{

    public GameObject[] Items;
    


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Items[Random.Range(0,Items.Length)]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
