using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleScene
{
    public class LevelManager : MonoBehaviour
    {
        [SerializeField]
        GameObject wallPrefab = null;

        [SerializeField]
        GameObject floorPrefab = null;

        void Start()
        {
            DungeonGenerator.GenerateDungeon(wallPrefab, floorPrefab);
        }
    }
}
