using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalLeft : MonoBehaviour
{
    //do enum innit
    
    //when ball collides, add a point
    public ParticleSystem leftGoalParticles1;
    public ParticleSystem leftGoalParticles2;
    public ParticleSystem rightGoalParticles1;
    public ParticleSystem rightGoalParticles2;

    private void OnEnable()
    {
        SoccerBall.GoalLeftEvent += leftGoal;
        SoccerBall.GoalRightEvent +=  rightGoal;
    }
    private void OnDisable()
    {
        SoccerBall.GoalLeftEvent -= leftGoal;
        SoccerBall.GoalRightEvent -=  rightGoal;
    }
    
    private void leftGoal()
    {
        leftGoalParticles1.Play();
        leftGoalParticles2.Play();
    }

    private void rightGoal()
    {
        rightGoalParticles1.Play();
        rightGoalParticles2.Play();
    }
}
