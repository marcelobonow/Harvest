using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CustomExceptions : Exception{

}

public class TileOutOfBonds : Exception {
    public TileOutOfBonds(Vector3 pos)
    {
        Debug.LogErrorFormat("Voce tentou acessar na posição x: {0}, z: {1}\n", pos.x, pos.z);
    }
}

