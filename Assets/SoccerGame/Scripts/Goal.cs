using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public delegate void GoalSignature(Goal goal);
    public event GoalSignature GoalEvent;

    public Team.TeamName teamName;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<SoccerBall>() != null)
        {
            GoalEvent?.Invoke(this);
        }
    }
}
