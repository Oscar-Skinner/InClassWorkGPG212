using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Goal[] goal;
    
    public TeamName teamName;
    public enum TeamName
    {
        Left,
        Right 
    }
        
    private void OnEnable()
    {
        foreach (Goal item in goal)
        {
            item.GoalEvent += GoalOnGoalEvent;
        }
    }
    
    // public delegate void ScoredGoal();
    // public event ScoredGoal TeamScored;
    public delegate void Scored(TeamName teams);
    public event Scored GoalRightEvent;
    public static event Scored GoalLeftEvent;
    void GoalOnGoalEvent(Goal newGoal)
    {
        // foreach (Team team in teams)
        // {
        //     check at home :D
        // }
        
        Debug.Log("got goal!"+newGoal);

        if (newGoal.name == "GoalLeft")
        {
            GoalRightEvent?.Invoke(TeamName.Right);
        }
        
        if (newGoal.name == "GoalRight")
        {
            GoalLeftEvent?.Invoke(TeamName.Left);
        }
    }
}
