using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Supporters : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.LeftScoresPoints += LeftCheer;
        EventManager.RightScoresPoints += RightCheer;
    }

    private void OnDisable()
    {
        EventManager.LeftScoresPoints -= LeftCheer;
        EventManager.RightScoresPoints -= RightCheer;

    }
    public void LeftCheer()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(0, Random.Range(3f,6f), 0);
    }
    public void RightCheer()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(0, Random.Range(3f,6f), 0);
    }
}
