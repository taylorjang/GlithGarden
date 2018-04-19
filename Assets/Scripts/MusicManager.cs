using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;

    private AudioSource audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnLevelWasLoaded(int level)
    {
        if (levelMusicChangeArray[level] != null)
        {
            audioSource.clip = levelMusicChangeArray[level];
            audioSource.loop = true;
            audioSource.Play();
        }

    }
}
