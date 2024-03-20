using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class HallwayRooms : MonoBehaviour
{
    public List<Transform> RoomLocations; 
    public GameObject Room;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < RoomLocations.Count; i++)
        {

            Instantiate(Room, RoomLocations[i].position, RoomLocations[i].rotation);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
