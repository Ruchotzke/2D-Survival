using Survival_2D.Simulation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Survival_2D.Graphics
{
    public class TilemapManager : MonoBehaviour
    {
        [Header("Tilemaps")]
        public Tilemap TerrainTilemap;

        [Header("Map")]
        public Vector2Int Size;

        Map map;

        private void Start()
        {
            map = new Map(Size);

            DrawMap();
        }

        public void DrawMap()
        {
            for(int y = 0; y < Size.y; y++)
            {
                for(int x = 0; x < Size.x; x++)
                {
                    /* Get the correct tile */
                    Cell cell = map.Cells[x, y];
                    TerrainTile curr = TileManager.Instance.Terrain[(int)cell.terrain];

                    /* Display this tile */
                    TerrainTilemap.SetTile(new Vector3Int(x, y, 0), curr);
                }
            }
        }
    }
}

