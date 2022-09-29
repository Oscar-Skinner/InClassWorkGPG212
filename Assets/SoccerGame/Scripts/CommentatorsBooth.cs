using UnityEngine;

public class CommentatorsBooth : MonoBehaviour
{
    private void OnEnable()
    {
        InvisibleWalls.OutOfBounds += BallIsOutComment;
        GameManager.CheerAndCleanUp += GoalCommentary;
    }
    private void OnDisable()
    {
        InvisibleWalls.OutOfBounds -= BallIsOutComment;
        GameManager.CheerAndCleanUp -= GoalCommentary;
    }

    private void Start()
    {
        print("Today a lovely day for a soccer game. The sun is shining and all the players are on the pitch ready for a good game.");
    }

    void BallIsOutComment()
    {
        print("Lucky for those invisible walls because the ball has stayed in!");
    }
    private void GoalCommentary()
    {
        print("!!!GOAL!!!");
    }
}
