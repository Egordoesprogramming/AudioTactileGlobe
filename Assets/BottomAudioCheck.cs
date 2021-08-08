using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomAudioCheck : MonoBehaviour {

    AudioSource bottomAudio;
    public AudioSource topAudio;
    public AudioSource mainAudio;
    // Use this for initialization

    void Start()
    {
        bottomAudio = GetComponent<AudioSource>();
    }

    public void PlayBottomAudio()
    {
        topAudio.Stop();
        mainAudio.Stop();
        bottomAudio.Play();
    }
}
