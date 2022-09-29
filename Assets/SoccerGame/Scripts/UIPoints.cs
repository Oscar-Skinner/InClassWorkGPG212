using UnityEngine;
using TMPro;

public class UIPoints : MonoBehaviour
{
    //for the UI
    public TMP_Text leftDisplayedPoints;
    public TMP_Text rightDisplayedPoints;
    

    void OnEnable()
    {
        GameManager.TeamThatScored += PointsDisplay;
    }
    void OnDisable()
    {
        GameManager.TeamThatScored -= PointsDisplay;
    }
    private void PointsDisplay(int left, int right)
    {
        print("points printing");
        leftDisplayedPoints.text = "Left Team Score: " + left;
        rightDisplayedPoints.text = "Right Team Score: " + right;
    }

    

    void Start()
    {
        leftDisplayedPoints.text = "Left Team Score: 0";
        rightDisplayedPoints.text = "Right Team Score: 0";
    }
    
}
