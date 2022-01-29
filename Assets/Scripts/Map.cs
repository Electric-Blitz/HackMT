using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EntityTypes
{
    Empty,
    Wall,       //Edge of map
    ResourceStone,
    ResourceWood,
    ABuilder,
    AMelee,
    AGatherer,
    ARanged,
    AHouse,     //Allied House
    ADefensive,
    AStockpile,
    EBuilder,
    EMelee,
    ERanged,
    EHouse,
    EDefensive
};


public class Map : MonoBehaviour
{
    public Transform HousePrefab;
    public Transform DefensivePrefab;
    public Transform StockpilePrefab;
    public Transform BuildingResource;
    public Transform PersonResource;
    public Transform BuilderPrefab;
    public Transform GathererPrefab;
    public Transform MeleePrefab;
    public Transform RangedPrefab;
    public Transform BbuilderPrefab;
    public Transform BmeleePrefab;
    public Transform BrangedPrefab;

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

    public EntityTypes PosVal(int x, int y) //return enum type in pos [x,y]
    {
        return M[x, y];
    }

    public Vector3 PosV3(float x, float y)
    {
        Vector3 finalPos;
        finalPos.x = (float)x * spacing;
        finalPos.y = 0.1f;
        finalPos.z = (float)y * spacing;
        return finalPos;
    }

    public void setHouse(int x, int y)
    {
        if (M[x, y] == EntityTypes.Empty && M[x - 1, y] == EntityTypes.Empty && M[x - 1, y - 1] == EntityTypes.Empty && M[x, y - 1] == EntityTypes.Empty)
        {
            M[x, y] = EntityTypes.AHouse;
            M[x - 1, y] = EntityTypes.AHouse;
            M[x - 1, y - 1] = EntityTypes.AHouse;
            M[x, y - 1] = EntityTypes.AHouse;
            spawnHouse(PosV3((float)x, (float)y));
        }
    }

    private void spawnHouse(Vector3 position)
    {
        Instantiate(HousePrefab, position, Quaternion.identity);
    }

    public void setDefensive(int x, int y)
    {
        if (M[x, y] == EntityTypes.Empty)
        {
            M[x, y] = EntityTypes.ADefensive;
            spawnDefensive(PosV3((float)x, (float)y));
        }
    }

    private void spawnDefensive(Vector3 position)
    {
        Instantiate(DefensivePrefab, position, Quaternion.identity);
    }

    public void setStockpile(int x, int y)
    {
        if (M[x, y] == EntityTypes.Empty)
        {
            if (M[x, y] == EntityTypes.Empty && M[x - 1, y] == EntityTypes.Empty && M[x - 1, y - 1] == EntityTypes.Empty && M[x, y - 1] == EntityTypes.Empty)
            {
                M[x, y] = EntityTypes.AStockpile;
                M[x - 1, y] = EntityTypes.AStockpile;
                M[x - 1, y - 1] = EntityTypes.AStockpile;
                M[x, y - 1] = EntityTypes.AStockpile;
                spawnStockpile(PosV3((float)x, (float)y));
            }
        }
    }

    private void spawnStockpile(Vector3 position)
    {
        Instantiate(StockpilePrefab, position, Quaternion.identity);
    }

    //should be given AWorker, AGatherer, AMelee, or ARanged
    public void setCurPlayer(int x, int y, EntityTypes set)
    {
        if (M[x, y] == EntityTypes.Empty)
        {
            M[x, y] = set;
            spawnCurPlayer(PosV3((float)x, (float)y), set);
        }
    }

    private void spawnCurPlayer(Vector3 position, EntityTypes set)
    {
        switch (set)
        {
            case EntityTypes.ABuilder:
                Instantiate(BuilderPrefab, position, Quaternion.identity);
                break;
            case EntityTypes.AGatherer:
                Instantiate(GathererPrefab, position, Quaternion.identity);
                break;
            case EntityTypes.AMelee:
                Instantiate(MeleePrefab, position, Quaternion.identity);
                break;
            case EntityTypes.ARanged:
                Instantiate(RangedPrefab, position, Quaternion.identity);
                break;
        }
    }

    public bool moveCurPlayer(int space)
    {
        if(space == 2)
            {

            }

        if (space == 4)
            {

            }

        if (space == 6)
            {

            }

        if (space == 8)
            {

            }

        return false;
    }


    //takes EMelee, ERanged, and EBuilder
    public void setEnemy(int x, int y, EntityTypes set)
    {
        if (M[x, y] == EntityTypes.Empty)
        {
            M[x, y] = set;
            spawnEnemy(PosV3((float)x, (float)y), set);
        }
    }

    private void spawnEnemy(Vector3 position, EntityTypes set)
    {
        switch (set)
        {
            case EntityTypes.EBuilder:
                Instantiate(BbuilderPrefab, position, Quaternion.identity);
                break;
            case EntityTypes.EMelee:
                Instantiate(BmeleePrefab, position, Quaternion.identity);
                break;
            case EntityTypes.ERanged:
                Instantiate(BrangedPrefab, position, Quaternion.identity);
                break;
        }
    }

    private void setWood(int x, int y)
    {
        M[x, y] = EntityTypes.ResourceWood;
        M[x - 1, y] = EntityTypes.ResourceWood;
        spawnWood(PosV3((float)x, (float)y));
    }

    private void spawnWood(Vector3 position)
    {
        Instantiate(BuildingResource, position, Quaternion.identity);
    }

    private void setFood(int x, int y)
    {
        M[x, y] = EntityTypes.ResourceStone;
        M[x - 1, y] = EntityTypes.ResourceStone;
        spawnFood(PosV3((float)x, (float)y));
    }

    private void spawnFood(Vector3 position)
    {
        Instantiate(PersonResource, position, Quaternion.identity);
    }
}