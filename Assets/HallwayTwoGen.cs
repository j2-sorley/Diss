using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayTwoGen : MonoBehaviour
{

    public List<Transform> largeRoomLocations;
    public List<Transform> smallRoomLocations;
    public List<Transform> HallwayExitOne;
    public List<Transform> HallwayExitTwo;
    public List<Transform> HallwayExitThree;
    public List<Transform> HallwayExitFour;
    public List<GameObject> Hallways;
    public GameObject Room;
    public GameObject[] SmallRoom;
    public bool ExitOneBlockedBool;
    public bool ExitTwoBlockedBool;
    public bool ExitThreeBlockedBool;
    public bool ExitFourBlockedBool;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
