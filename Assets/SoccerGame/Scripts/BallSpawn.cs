using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject Ball;

    private void OnEnable()
    {
        SoccerBall.GoalLeftEvent += BallRespawn;
        SoccerBall.GoalRightEvent += BallRespawn;
    }

    private void OnDisable()
    {
        SoccerBall.GoalLeftEvent -= BallRespawn;
        SoccerBall.GoalRightEvent -= BallRespawn;
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
