using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confetti : MonoBehaviour
{
    public Goal[] goal;
    
    public ParticleSystem leftGoalParticles1;
    public ParticleSystem leftGoalParticles2;
    public ParticleSystem rightGoalParticles1;
    public ParticleSystem rightGoalParticles2;

    void OnEnable()
    {
        for (var index = 0; index <goal.Length; index++)
        {
            var item = goal[index];
            item.GoalEvent += confettiLaunch;
        }
    }

    private void confettiLaunch(Goal newGoal)
    {
        if (newGoal.name == "GoalLeft")
        {
            leftGoalParticles1.Play();
            leftGoalParticles2.Play();
        }

        if (newGoal.name == "GoalRight")
        {
            rightGoalParticles1.Play();
            rightGoalParticles2.Play();
        }
    }
    
}
