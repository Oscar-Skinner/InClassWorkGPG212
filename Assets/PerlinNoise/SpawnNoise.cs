using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNoise : MonoBehaviour
{
    public GameObject Prefab;
    
    public int amount = 20;

    private float scaleX = 1f;

    private float heightScale = 2f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < amount; x++)
        {
            float height = heightScale * Mathf.PerlinNoise(scaleX, 0f);
            Instantiate(Prefab, new Vector3(x, height, 0), Quaternion.identity);
        }
    }
}
