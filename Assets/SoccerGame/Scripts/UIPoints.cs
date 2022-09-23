using UnityEngine;
using TMPro;

public class UIPoints : MonoBehaviour
{
    //for the UI
    public TMP_Text leftDisplayedPoints;
    public TMP_Text rightDisplayedPoints;
    private string _left;
    private string _right;
    
    //for the total amount of points for each team.
    private float _leftPointTotal = 0;
    private float _rightPointTotal = 0;

    void OnEnable()
    {
        EventManager.LeftScoresPoints += LeftScoresGetsPoints;
        EventManager.RightScoresPoints += RightScoresGetsPoints;
    }
    void OnDisable()
    {
        EventManager.LeftScoresPoints -= LeftScoresGetsPoints;
        EventManager.RightScoresPoints -= RightScoresGetsPoints;
    }

    void Start()
    {
        leftDisplayedPoints.text = "Left Team Score: " + _leftPointTotal;
        rightDisplayedPoints.text = "Right Team Score: " + _rightPointTotal;
    }

    void LeftScoresGetsPoints()
    {
        _leftPointTotal ++;
        leftDisplayedPoints.text = "Left Team Score: " + _leftPointTotal;
    }
    void RightScoresGetsPoints()
    {
        _rightPointTotal ++;
        rightDisplayedPoints.text = "Right Team Score: " + _rightPointTotal;
    }

}
