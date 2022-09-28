using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{
    public Material leftTeam;
    public Material rightTeam;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Goal>() != null)
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.GetComponent<Goal>() != null)
        {
            Destroy(this.gameObject);
        }
    }
}