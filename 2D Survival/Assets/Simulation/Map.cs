using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Survival_2D.Simulation
{
    public class Map
    {
        /* Map Layout */
        public Cell[,] Cells;
        public Vector2Int Size;

        List<Vector3Int> DEBUG_WALL_TILES = new List<Vector3Int>() {
            new Vector3Int(0, 7),

            new Vector3Int(0, 5),
            new Vector3Int(1, 5),
            new Vector3Int(2, 5),
            new Vector3Int(0, 4),
            new Vector3Int(2, 4),
            new Vector3Int(0, 3),
            new Vector3Int(1, 3),
            new Vector3Int(2, 3),

            new Vector3Int(4, 7),
            new Vector3Int(4, 6),
            new Vector3Int(4, 5),
            new Vector3Int(5, 6),

            new Vector3Int(8, 7),
            new Vector3Int(8, 6),
            new Vector3Int(8, 5),
            new Vector3Int(7, 6),

            new Vector3Int(5, 3),
            new Vector3Int(6, 3),
            new Vector3Int(7, 3),
            new Vector3Int(6, 4),

            new Vector3Int(5, 1),
            new Vector3Int(6, 1),
            new Vector3Int(7, 1),
            new Vector3Int(6, 0),

            new Vector3Int(9, 3),
            new Vector3Int(10, 3),
            new Vector3Int(11, 3),
            new Vector3Int(10, 2),
            new Vector3Int(10, 4),
        };

        public Map(Vector2Int size)
        {
            this.Size = size;
            Cells = new Cell[Size.x, Size.y];

            for(int y = 0; y < Size.y; y++)
            {
                for(int x = 0; x < Size.x; x++)
                {
                    Cells[x, y] = new Cell(TerrainType.Grass);
                    Cells[x,y].HasWall = (DEBUG_WALL_TILES.Contains(new Vector3Int(x,y))) ? true : false;
                }
            }
        }
    }
}

