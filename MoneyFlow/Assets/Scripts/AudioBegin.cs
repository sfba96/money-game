using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioBegin : MonoBehaviour
{
    static bool audioBegin = false;
    [SerializeField] AudioSource audioClip;

    void Awake()
    {
        if (!audioBegin)
        {
            audioClip.Play();
            DontDestroyOnLoad(gameObject);
            audioBegin = true;
        }
    }

    void Update()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex == 0)
        {
            audioClip.Stop();
            audioBegin = false;
        }
    }
}
