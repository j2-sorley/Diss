using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoSelector : MonoBehaviour
{

    public VideoPlayer player;
    public VideoClip[] videos; 
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<VideoPlayer>();
        int i = Random.Range(0,videos.Length);
        player.clip = videos[i];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
