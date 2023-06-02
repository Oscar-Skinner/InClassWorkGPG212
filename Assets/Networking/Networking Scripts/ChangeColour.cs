using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class ChangeColour : NetworkBehaviour
{
    public NetworkVariable<Vector4> ColorValue  = new NetworkVariable<Vector4>();

    
    public override void OnNetworkSpawn()
    {
        if (IsOwner)
        {
            ChangeTheColor();
        }
    }

    public void ChangeTheColor()
    {
        if (NetworkManager.Singleton.IsServer)
        {
            Vector4 randomColour = GetRandomColourValue();
            SetColor(randomColour);
        }
        else
        {
            SubmitMaterialIndexRequestServerRpc();
        }
    }

    [ServerRpc]
    void SubmitMaterialIndexRequestServerRpc(ServerRpcParams rpcParams = default)
    {
        Vector4 randomIndex = GetRandomColourValue();
        SetColor(randomIndex);
    }

    void SetColor(Vector4 color)
    {
        ColorValue.Value = color;
        // Apply the material change to the object
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null && renderer.sharedMaterials != null)
        {
            Material newMaterial = new Material(renderer.sharedMaterial);
            newMaterial.color = new Color(color.x / 255f, color.y / 255f, color.z / 255f, color.w / 255f);
            renderer.material = newMaterial;
        }
    }
    
    static Vector4 GetRandomColourValue()
    {
        return new Vector4(Random.Range(0,255),Random.Range(0,255),Random.Range(0,255),255);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeTheColor();
        }
        SetColor(ColorValue.Value);
    }
}
