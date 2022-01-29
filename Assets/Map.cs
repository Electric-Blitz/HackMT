using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EntityTypes
{
    Empty,
    Wall,
    ResourceStone,
    ResourceWood,
    ABuilder,
    AMelee,
    AGatherer,
    ARanged,
    AHouse,
    ADefensive,
    EBuilder,
    EMelee,
    ERanged,
    EHouse,
    EDefensive
};


public class Map : MonoBehaviour
{
    int mapSize = 50;
    EntityTypes[,] M;
    float spacing = 1.5f;

    void Start()
    {
        M = new EntityTypes[mapSize, mapSize];
        for (int i = 0; i < mapSize; i++)
        {
            for (int j = 0; j < mapSize; j++)
            {
                if (i == 0 | j == 0 | i == (mapSize - 1) | j == (mapSize - 1))
                {
                    M[i, j] = EntityTypes.Wall;
                }
                else
                {
                    M[i, j] = EntityTypes.Empty;
                }
            }
        }
    }

    public EntityTypes PosVal(int x, int y)
    {
        return M[x, y];
    }

    public Vector3 PosV3(float x, float y)
    {
        Vector3 finalPos;
        finalPos.x = (float)x * spacing;
        finalPos.y = 1;
        finalPos.z = (float)y * spacing;
        return finalPos;
    }

}