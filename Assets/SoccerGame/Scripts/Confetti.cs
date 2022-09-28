using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confetti : MonoBehaviour
{
    public ParticleSystem leftGoalParticles1;
    public ParticleSystem leftGoalParticles2;
    public ParticleSystem rightGoalParticles1;
    public ParticleSystem rightGoalParticles2;
    private void OnEnable()
    {
        GameManager.GoalLeftEvent += leftGoal;
        GameManager.GoalRightEvent +=  rightGoal;
    }
    private void OnDisable()
    {
        GameManager.GoalLeftEvent -= leftGoal;
        GameManager.GoalRightEvent -=  rightGoal;
    }
    
    private void leftGoal()
    {
        rightGoalParticles1.Play();
        rightGoalParticles2.Play();
    }

    private void rightGoal()
    {
        leftGoalParticles1.Play();
        leftGoalParticles2.Play();
    }
}
