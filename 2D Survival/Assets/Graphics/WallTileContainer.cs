using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu()]
public class WallTileContainer : ScriptableObject
{
    /// <summary>
    /// Walltiles organized in the binary layout order (W, S, E, N in binary).
    /// </summary>
    [Tooltip("Tiles in binary ordering NESW")] public Sprite[] WallTiles;
}
