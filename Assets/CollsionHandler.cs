using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollsionHandler : MonoBehaviour
{

    [SerializeField] GameObject deathFX;
    [SerializeField] int levelLoadDelay = 2;

    private void OnTriggerEnter(Collider other)
    {
        print("collided" + other.name);
        SendMessage("disableControls");
        deathFX.SetActive(true);
        Invoke("reloadLevel",levelLoadDelay);
    }

    private void reloadLevel()
    {
        SceneManager.LoadScene(1);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("collided");
    }

}
