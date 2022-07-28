using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Survival_2D.Simulation
{
    public class Cell
    {
        public bool HasWall;
        public TerrainType terrain;
        public Cell(TerrainType terrain)
        {
            this.terrain = terrain;
            HasWall = false;
        }
    }
}

