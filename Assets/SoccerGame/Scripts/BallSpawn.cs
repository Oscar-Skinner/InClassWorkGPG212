using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject Ball;

    private void OnEnable()
    {
        GameManager.CheerAndCleanUp += RespawnBall;
    }

    private void OnDisable()
    {
        GameManager.CheerAndCleanUp -= RespawnBall;
    }

    void Start()
    {
        Instantiate(Ball);
    }
    
    private void RespawnBall()
    {
        Instantiate(Ball);
    }

    
}
