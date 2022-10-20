using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenCT : MonoBehaviour
{
    private AudioSource _audioSource;
    public void close()
    {
        Application.Quit();
    }

    public static void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}
