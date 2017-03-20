using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour {
    AudioSource sound;
    public AudioClip jumpSound;
    public AudioClip walkSound;
    // Use this for initialization
    void Start () {
        sound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.W)) {

            sound.clip = walkSound;
            sound.loop = true;
            sound.Play();
            
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            if(sound.clip == walkSound)
            sound.loop = false;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            sound.clip = jumpSound;
            sound.Play();
            sound.loop = false;
            
        }


    }
}
