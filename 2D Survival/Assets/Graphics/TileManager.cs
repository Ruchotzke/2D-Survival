using Survival_2D.Simulation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Survival_2D.Graphics
{
    /// <summary>
    /// A factory used to load and manage tile instances.
    /// </summary>
    public class TileManager : MonoBehaviour
    {
        public const string TerrainPath = "Terrain/";

        #region SINGLETON
        public static TileManager Instance
        {
            get
            {
                if(_singleton == null) _singleton = FindObjectOfType<TileManager>();
                return _singleton;
            }
        }
        private static TileManager _singleton;
        #endregion

        public TerrainTile[] Terrain;

        private void Awake()
        {
            /* Generate a tile for each terrain type */
            var terrainVals = System.Enum.GetValues(typeof(TerrainType));
            Terrain = new TerrainTile[terrainVals.Length];
            foreach(var terraintype in terrainVals)
            {
                Sprite spr = Resources.Load<Sprite>(TerrainPath + terraintype.ToString());
                if (spr == null) Debug.LogError("Unable to find sprite for " + TerrainPath + terraintype.ToString());
                TerrainTile curr = ScriptableObject.CreateInstance<TerrainTile>();
                curr.sprite = spr;
                Terrain[(int)terraintype] = curr;
            }
            
        }
    }
}

