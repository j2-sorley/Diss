using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GenController : MonoBehaviour
{
    public int Hallways;
    public TextMeshProUGUI HallwayNumberText;
    public TMP_InputField input;
    public GameObject StartSystem;
    public int CurrentHallways;
    public bool MoreHallways; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Hallways > CurrentHallways) {MoreHallways = true;}
        if (Hallways == CurrentHallways) {MoreHallways = false; Debug.Log("Met"); }
        if (Hallways < CurrentHallways) { MoreHallways = false; Debug.Log("Met"); }
    }

    public void hallwayLimitSet() 
    {
      Hallways = int.Parse(input.text);
      StartSystem.SetActive(true);
    }

    public void HallwayIntAdd()
    {
        CurrentHallways++;
        HallwayNumberText.text = CurrentHallways.ToString();
        Debug.Log("Bingo"); 
        

    }




}
