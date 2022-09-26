using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommentatorsBooth : MonoBehaviour
{
    private void OnEnable()
    {
        InvisibleWalls.OutOfBounds += BallIsOutComment;
        SoccerBall.GoalEvent += GoalScored;
    }
    private void OnDisable()
    {
        InvisibleWalls.OutOfBounds -= BallIsOutComment;
        SoccerBall.GoalEvent -= GoalScored;
    }

    void BallIsOutComment()
    {
        print("Lucky for those invisible walls because the ball has stayed in!");
    }
    private void GoalScored()
    {
        print("!!!GOAL!!!");
    }
    
}
