using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {
    UInt16 id;
    Byte thing; ///aqui é provavelmente um enumerator, dizendo o que que é essa tile
    
    public static UInt16 GetIdByPosition(Vector3 position)
    {
        if(position.z > 255 || position.x > 255)
        {
            throw new TileOutOfBonds(position);
        }
        UInt16 tempid = (UInt16)(position.x + (position.z*256));
        return tempid;
    }
}
