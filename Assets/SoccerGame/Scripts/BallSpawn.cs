using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject Ball;

    public GameManager gameManager;
    
    private void OnEnable()
    {
        
        gameManager.GoalRightEvent += BallRespawn;
        
    }

    private void BallRespawn(GameManager.TeamName teamName)
    {
        if (teamName == GameManager.TeamName.Right)
        {
            Instantiate(Ball);
        }
        else if (teamName == GameManager.TeamName.Left)
        {
            Instantiate(Ball);
        }
        {
            
        }
        print("did something");        
    }

    void Start()
    {
        Instantiate(Ball);
    }
}
