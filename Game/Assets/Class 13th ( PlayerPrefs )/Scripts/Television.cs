using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Video;

public class Television : MonoBehaviour
{
    [SerializeField] public VideoClip[] videoClips;
    VideoPlayer videoPlayer;    
    private void Awake()
    {
       videoPlayer = GetComponentInChildren<VideoPlayer>();

    }

    void Start()
    {
        videoPlayer.clip = videoClips[PlayerPrefs.GetInt("Channel")];
        videoPlayer.Play();
    } 
    public void Increase()
    {
        int channel = PlayerPrefs.GetInt("Channel");
        channel++;     
        channel %= videoClips.Length;        
        PlayerPrefs.SetInt("Channel", channel);
        videoPlayer.clip = videoClips[channel];
        videoPlayer.Play();        
    }
}
