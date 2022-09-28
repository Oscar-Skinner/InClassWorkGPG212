using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommentatorsBooth : MonoBehaviour
{
    private void OnEnable()
    {
        InvisibleWalls.OutOfBounds += BallIsOutComment;
        SoccerBall.GoalLeftEvent += LeftTeamScored;
        SoccerBall.GoalRightEvent += RightTeamScored;
    }
    private void OnDisable()
    {
        InvisibleWalls.OutOfBounds -= BallIsOutComment;
        SoccerBall.GoalLeftEvent -= LeftTeamScored;
        SoccerBall.GoalRightEvent -= RightTeamScored;
    }

    private void Start()
    {
        print("Today a lovely day for a soccer game. The sun is shining and all the players are on the pitch ready for a good game.");
    }

    void BallIsOutComment()
    {
        print("Lucky for those invisible walls because the ball has stayed in!");
    }
    private void LeftTeamScored()
    {
        print("!!!GOAL!!!");
        print("THE LEFT TEAM SCORES THE POINT!");
    }
    private void RightTeamScored()
    {
        print("!!!GOAL!!!");
        print("THE RIGHT TEAM SCORES THE POINT!");
    }
}
