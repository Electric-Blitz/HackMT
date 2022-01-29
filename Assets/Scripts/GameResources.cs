using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameResources : MonoBehaviour
{
    public int BuildingResources = 0;
    public int PersonResources = 5;

    public void addResources(bool isBuilding)
    {
        if (isBuilding)
        {
            BuildingResources += 5;
        }
        else
        {
            PersonResources += 5;
        }
    }

    public void removeResources(bool isBuilding, int amt)
    {
        if (isBuilding)
        {
            BuildingResources -= amt;
        }
        else
        {
            PersonResources -= amt;
        }
    }
}