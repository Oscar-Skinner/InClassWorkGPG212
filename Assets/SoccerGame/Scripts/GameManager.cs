using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Goal[] goal;
    
    public Team.TeamName teamName;

    private void Start()
    {
        for (var index = 0; index <goal.Length; index++)
        {
            var item = goal[index];
            item.GoalEvent += GoalOnGoalEvent;
        }
    }
    
    // public delegate void ScoredGoal();
    // public event ScoredGoal TeamScored;
    public delegate void Scored();
    public static event Scored GoalRightEvent;
    public static event Scored GoalLeftEvent;
    void GoalOnGoalEvent(Goal newGoal)
    {
        Debug.Log("got goal!"+newGoal);

        if (newGoal.name == "GoalLeft")
        {
            GoalRightEvent?.Invoke();
        }
        
        if (newGoal.name == "GoalRight")
        {
            GoalLeftEvent?.Invoke();
        }
    }
}
