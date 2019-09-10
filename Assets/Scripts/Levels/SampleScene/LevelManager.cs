using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleScene
{
    public class LevelManager : MonoBehaviour
    {
        [SerializeField]
        GameObject wallPrefab;

        [SerializeField]
        GameObject floorPrefab;

        void Start()
        {
            DungeonGenerator.GenerateDungeon(wallPrefab, floorPrefab);
        }
    }
}
