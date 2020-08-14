using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MediaPlayer : MonoBehaviour
{

    AudioSource audioSource;

    private void Awake()
    {
        int numMusicPLayer = FindObjectsOfType<MediaPlayer>().Length;
        if (numMusicPLayer > 1)
            Destroy(gameObject);
        else
            DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("loadFirstScene", 2f);
    }

    // Update is called once per frame
    void loadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
