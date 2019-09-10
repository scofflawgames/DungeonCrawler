using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonGenerator 
{
    public static void GenerateDungeon(GameObject wallPrefab, GameObject floorPrefab)
    {
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if ((i < 1 || i > 5) || (j < 1 || j > 5))
                {
                    GameObject.Instantiate(wallPrefab, new Vector3(i - 3f, 0.5f, j - 3f), Quaternion.identity);
                }
            }
        }

        GameObject floorObject = GameObject.Instantiate(floorPrefab);
        floorObject.GetComponent<MeshRenderer>().material.mainTextureScale = new Vector2(10f,10f);
        floorObject.transform.position = new Vector3(0, 0, 0);
    }
}
