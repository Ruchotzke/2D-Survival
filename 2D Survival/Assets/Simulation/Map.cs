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


        public Map(Vector2Int size)
        {
            this.Size = size;
            Cells = new Cell[Size.x, Size.y];

            for(int y = 0; y < Size.y; y++)
            {
                for(int x = 0; x < Size.x; x++)
                {
                    Cells[x, y] = new Cell((TerrainType)Random.Range(0, 3));
                }
            }
        }
    }
}

