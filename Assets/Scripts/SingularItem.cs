using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingularItem : MonoBehaviour
{

    public GameObject Item;
    public int chance; 
    // Start is called before the first frame update
    void Start()
    {
        chance = Random.Range(0, 100);

        if (chance < 20)
        {
            Item.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
