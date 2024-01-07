using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionParticals : MonoBehaviour
{
    public bool InRange;
    public bool Enabled; 
    public GameObject particals; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (InRange)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                if (!Enabled)
                {
                    particals.SetActive(true);
                    Enabled = true; 
                }

                else
                {
                    particals.SetActive(false);
                    Enabled = false; 
                }
                
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            InRange = true;
             
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InRange = false;
           
        }
    }
}
