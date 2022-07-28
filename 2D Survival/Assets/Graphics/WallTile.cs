using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Survival_2D.Graphics
{
    public class WallTile : TileBase
    {
        public WallTileContainer sprites;

        public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
        {
            int index = 0;
            if (tilemap.GetTile(position + Vector3Int.up) != null) index += 1;
            if (tilemap.GetTile(position + Vector3Int.right) != null) index += 2;
            if (tilemap.GetTile(position + Vector3Int.down) != null) index += 4;
            if (tilemap.GetTile(position + Vector3Int.left) != null) index += 8;
            tileData.sprite = sprites.WallTiles[index];
        }

        public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
        {
            return base.GetTileAnimationData(position, tilemap, ref tileAnimationData);
        }

        public override void RefreshTile(Vector3Int position, ITilemap tilemap)
        {
            /* Alert our neighbors to update their data */
            if (tilemap.GetTile(position + Vector3Int.up) != null) tilemap.RefreshTile(position + Vector3Int.up);
            if (tilemap.GetTile(position + Vector3Int.down) != null) tilemap.RefreshTile(position + Vector3Int.down);
            if (tilemap.GetTile(position + Vector3Int.left) != null) tilemap.RefreshTile(position + Vector3Int.left);
            if (tilemap.GetTile(position + Vector3Int.right) != null) tilemap.RefreshTile(position + Vector3Int.right);

            /* finally update ourselves */
            tilemap.RefreshTile(position);
        }

        public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
        {
            return base.StartUp(position, tilemap, go);
        }

    }
}

