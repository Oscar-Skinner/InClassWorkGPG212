using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Goal[] goal;

    public Team.TeamName teamName;
    
    public int scoreLeft;
    public int scoreRight;

    
    private void Start()
    {
        for (var index = 0; index <goal.Length; index++)
        {
            var item = goal[index];
            item.GoalEvent += GoalOnGoalEvent;
        }
    }

    public delegate void Scored();
    public static event Scored GoalRightEvent;
    public static event Scored GoalLeftEvent;
    void GoalOnGoalEvent(Goal newGoal)
    {
        Debug.Log("got goal!"+newGoal);

        if (newGoal.name == "GoalLeft")
        {
            scoreLeft++;
            print(scoreLeft);
            GoalRightEvent?.Invoke();
        }
        
        if (newGoal.name == "GoalRight")
        {
            scoreRight++;
            print(scoreRight);
            GoalLeftEvent?.Invoke();
        }
    }
}
