using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Rigidbody2D rbBullet;
    private float bulletForce = 5f;

    public void shoot()
    {
        //weapon should shoot the bullet and send it flying
        Rigidbody2D spawnedBullet = Instantiate(rbBullet, transform.position, Quaternion.identity);
        spawnedBullet.AddRelativeForce(Vector2.right * bulletForce, ForceMode2D.Impulse);
    }
}
