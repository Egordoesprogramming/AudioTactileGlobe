using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopAudioCheck : MonoBehaviour {

    AudioSource topAudio;
    public AudioSource bottomAudio;
    public AudioSource mainAudio;

    // Use this for initialization
    void Start () {
        topAudio = GetComponent<AudioSource>();

    }

    public void PlayTopAudio()
    {
        bottomAudio.Stop();
        mainAudio.Stop();
        topAudio.Play();
    }
    
}
