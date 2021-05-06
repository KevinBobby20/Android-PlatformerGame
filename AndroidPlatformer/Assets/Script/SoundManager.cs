using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip RunSound, JumpSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        RunSound = Resources.Load<AudioClip>("Run");
        JumpSound = Resources.Load<AudioClip>("Jump");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound (string clip)
    {
        switch(clip){
            case "Run":
            audioSrc.PlayOneShot (RunSound);
            break;
            case "Jump":
            audioSrc.PlayOneShot (JumpSound);
            break;
        }
    }
}
