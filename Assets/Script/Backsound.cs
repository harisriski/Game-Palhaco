using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Audio;
using System;

public class Backsound : MonoBehaviour
{

    public Sound[] sounds;

    public static Backsound instance;
    void Awake() {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {
        Play("Backsound");    
    }

    public void Play (string name) {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Suara: " + name + " Tidak ditemukan!");
        }
        s.source.Play();
        
    }
}
