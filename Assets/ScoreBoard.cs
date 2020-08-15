﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{

    [SerializeField] int scorePerHit = 10;

    int score;
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateScore() {
        score = score + scorePerHit;
        scoreText.text = score.ToString();
    }
}
