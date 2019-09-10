using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonWall : MonoBehaviour
{
    MeshFilter meshFilter;
    MeshRenderer meshRenderer;
    BoxCollider boxCollider;

    void Awake()
    {
        meshFilter = GetComponent<MeshFilter>();
        meshRenderer = GetComponent<MeshRenderer>();
        boxCollider = GetComponent<BoxCollider>();
        LoadTexture("dungeonwall");
    }

    public void LoadTexture(string textureName)
    {
        Texture texture = Resources.Load(textureName) as Texture;
        meshRenderer.material.mainTexture = texture;
    }



}
