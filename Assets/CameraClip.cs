using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClip : MonoBehaviour {

    public GameObject MountEverest;
    private Camera cam;
    private AudioSource sound;

	// Use this for initialization
	void Start () {
        cam = GetComponent<Camera>();
        sound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if ((cam.transform.position.x == MountEverest.transform.position.x)
            && cam.transform.position.z == MountEverest.transform.position.z)
        {
            sound.Play();
        }
	}
}
