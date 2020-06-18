using System;
using UnityEngine;
using UnityEngine.Audio;

public class audioManager : MonoBehaviour
{
[Header("Sound Array")]
public Sound[] sounds;
[HideInInspector]
public AudioSource source;

[Header("Groups")]
public AudioMixerGroup sfxGroup;
public AudioMixerGroup musicGroup;

    // Awake is called before the Start function
    void Awake()
    {

        DontDestroyOnLoad(gameObject);
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            if (s.isSFX == true)
            {
            s.source.outputAudioMixerGroup = sfxGroup;
            } else {
            s.source.outputAudioMixerGroup = musicGroup;
            }

        }
    }

public void Play (string name)
{
Sound s = Array.Find(sounds, sound => sound.name == name);
s.source.Play();

}
}
