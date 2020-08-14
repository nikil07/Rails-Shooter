﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Collider boxCollider =  gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = true;
    }

    private void OnParticleCollision(GameObject other)
    {
        print("Hit an enemy " + other.gameObject.name);
        Destroy(gameObject);
    }
}