using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonFloor : MonoBehaviour
{
    MeshFilter meshFilter;
    MeshRenderer meshRenderer;

    void Awake()
    {
        meshFilter = GetComponent<MeshFilter>();
        meshRenderer = GetComponent<MeshRenderer>();
        LoadTexture("dungeonfloor");
    }

    public void LoadTexture(string textureName)
    {
        Texture texture = Resources.Load(textureName) as Texture;
        meshRenderer.material.mainTexture = texture;
    }
}
