using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioContainer : MonoBehaviour
{
    public List<AudioClip> audioContainer;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void PlaySound(int listIndex)
    {
        _audioSource.clip = audioContainer[listIndex];
        _audioSource.Play();
    }
}
