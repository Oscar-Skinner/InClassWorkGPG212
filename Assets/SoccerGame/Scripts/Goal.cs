using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public delegate void GoalSignature(Goal goal);
    public event GoalSignature GoalEvent;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<SoccerBall>() != null)
        {
            GoalEvent?.Invoke(this);
        }
    }
}
