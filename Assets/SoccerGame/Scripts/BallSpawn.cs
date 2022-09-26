using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject Ball;

    private void OnEnable()
    {
        SoccerBall.GoalEvent += BallRespawn;
    }

    private void OnDisable()
    {
        SoccerBall.GoalEvent -= BallRespawn;
    }

    void Start()
    {
        Instantiate(Ball);
    }

    void BallRespawn()
    {
        Instantiate(Ball);
    }
    
}
