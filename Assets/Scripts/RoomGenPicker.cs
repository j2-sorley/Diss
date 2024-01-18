using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class RoomGenPicker : MonoBehaviour
{
    public GameObject[] RoomGens;
    private int weighting;


    [Header("Forced Spawning")]
    [Description("Only Pick One")]
    public bool ForceSpawn;
    public bool Bathroom;
    public bool kitchen;
    public bool Livingroom;
    public bool RareRoom;

    [Header("Forced Rooms")]
    public GameObject BathroomGen;
    public GameObject KitchenGen;
    public GameObject LivingRoomGen;
    public GameObject RareRoomGen;

    // Start is called before the first frame update
    void Start()
    {
        weighting = Random.Range(0, 100);
        //weighting = 1;
        Debug.Log(weighting);

        if (!ForceSpawn)
        {
            if(weighting == 0){Debug.Log("RareRoom");}
            if (weighting > 0  & weighting <21){Debug.Log("Bathroom"); RoomGens[0].SetActive(true);}
            if (weighting > 20 & weighting <51){Debug.Log("kitchen"); RoomGens[1].SetActive(true); }
            if (weighting > 50 & weighting<101){Debug.Log("LivingRoom"); RoomGens[2].SetActive(true); }
        }
        if (ForceSpawn)
        {
            if (Bathroom) {BathroomGen.SetActive(true);}
            if (kitchen)  {KitchenGen.SetActive(true);}
            if (Livingroom){LivingRoomGen.SetActive(true);}
            if (RareRoom) {RareRoomGen.SetActive(true);}
        }
             
        
            
       

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
