using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject Ball;

    private void OnEnable()
    {
        GameManager.GoalLeftEvent += BallRespawn;
        GameManager.GoalRightEvent += BallRespawn;
    }
    
    private void OnDisable()
    {
        GameManager.GoalLeftEvent -= BallRespawn;
        GameManager.GoalRightEvent -= BallRespawn;
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
