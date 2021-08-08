using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

    //public AudioClip EverestPreClip;
    public AudioSource EverestPreSource;
    public AudioSource button1Audio;
    public AudioSource button2Audio;
    public AudioSource intro;

    //public GameObject Tracker;
    int i = 0;
    bool check = true;
    bool playedOnce = false;

    // Use this for initialization
    void Start () {
        //EverestPreSource.clip = EverestPreClip;
        intro.Play();
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        //RaycastHit hit2;
        Ray LineOfSight = new Ray(transform.position, transform.forward);

        //Vector3 dir = new Vector3(-Tracker.transform.position.x, Tracker.transform.position.y, Tracker.transform.position.z);

        //Ray GlobeSight = new Ray(transform.position, dir);

        i++;

        if (EverestPreSource.isPlaying)
        {
            check = false;
        }else
            check = true;

        if(Physics.Raycast(LineOfSight, out hit, 1))
        {

            if (i > 200 && check && !playedOnce)
            {
                button1Audio.Stop();
                button2Audio.Stop();
                    EverestPreSource.Play();
                playedOnce = true;
                    i = 0;
            }
        }

        //if (Physics.Raycast(GlobeSight, out hit2, 1))
        //{
        //    Debug.Log(hit2.distance);
        //}

        //Debug.DrawRay(transform.position, dir);
        Debug.DrawRay(transform.position, transform.forward);
	}
}
