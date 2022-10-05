using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnNoise : MonoBehaviour
{
    public GameObject Prefab;
    public List<GameObject> cubeLand = new List<GameObject>();

    private int amount = 200;

    public float scale = 40;
    public float zoom;

    private float timer;
    private float interval = 1f;
    private float x;
    private float y;
    private Vector3 prefabPosition;

    private void Start()
    {
        for (int positionX = 0; positionX < amount; positionX++)
        { 
            for (int positionZ = 0; positionZ < amount; positionZ++)
            {
                prefabPosition.x = positionX;
                prefabPosition.y = Mathf.PerlinNoise((positionX * zoom), (positionZ * zoom)) * scale;
                prefabPosition.z = positionZ;
                GameObject newCube = Instantiate(Prefab, prefabPosition, Quaternion.identity);
                cubeLand.Add(newCube.gameObject);
            }
        }
    }

}
