using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Action Function Guideline
public class AFG : MonoBehaviour
{
    public Map map;
    //assumes knows its own x,y
    int x = 13;
    int y = 13;
    private bool checkAction()
    {
        EntityTypes MyVal = map.PosVal(x, y);
        EntityTypes[] nextDoor;
        switch (MyVal)
        {
            case EntityTypes.AMelee:
                //0 north, 1 east, 2 south, 3 west
                nextDoor = new EntityTypes[4];
                nextDoor[0] = map.PosVal(x - 1, y);
                nextDoor[1] = map.PosVal(x, y + 1);
                nextDoor[2] = map.PosVal(x + 1, y);
                nextDoor[3] = map.PosVal(x, y - 1);
                if (nextDoor[0] == EntityTypes.EBuilder || nextDoor[0] == EntityTypes.EMelee || nextDoor[0] == EntityTypes.EDefensive || nextDoor[0] == EntityTypes.ERanged || nextDoor[0] == EntityTypes.EHouse)
                {
                    return true;
                }
                if (nextDoor[1] == EntityTypes.EBuilder || nextDoor[1] == EntityTypes.EMelee || nextDoor[1] == EntityTypes.EDefensive || nextDoor[1] == EntityTypes.ERanged || nextDoor[1] == EntityTypes.EHouse)
                {
                    return true;
                }
                if (nextDoor[2] == EntityTypes.EBuilder || nextDoor[2] == EntityTypes.EMelee || nextDoor[2] == EntityTypes.EDefensive || nextDoor[2] == EntityTypes.ERanged || nextDoor[2] == EntityTypes.EHouse)
                {
                    return true;
                }
                if (nextDoor[3] == EntityTypes.EBuilder || nextDoor[3] == EntityTypes.EMelee || nextDoor[3] == EntityTypes.EDefensive || nextDoor[3] == EntityTypes.ERanged || nextDoor[3] == EntityTypes.EHouse)
                {
                    return true;
                }
                break;

            case EntityTypes.AGatherer:
                nextDoor = new EntityTypes[4];
                nextDoor[0] = map.PosVal(x - 1, y);
                nextDoor[1] = map.PosVal(x, y + 1);
                nextDoor[2] = map.PosVal(x + 1, y);
                nextDoor[3] = map.PosVal(x, y - 1);
                if (nextDoor[0] == EntityTypes.ResourceWood || nextDoor[0] == EntityTypes.ResourceStone)
                {
                    return true;
                }
                if (nextDoor[1] == EntityTypes.ResourceWood || nextDoor[1] == EntityTypes.ResourceStone)
                {
                    return true;
                }
                if (nextDoor[2] == EntityTypes.ResourceWood || nextDoor[2] == EntityTypes.ResourceStone)
                {
                    return true;
                }
                if (nextDoor[3] == EntityTypes.ResourceWood || nextDoor[3] == EntityTypes.ResourceStone)
                {
                    return true;
                }
                break;

            case EntityTypes.ABuilder:
                nextDoor = new EntityTypes[4];
                nextDoor[0] = map.PosVal(x - 1, y);
                nextDoor[1] = map.PosVal(x, y + 1);
                nextDoor[2] = map.PosVal(x + 1, y);
                nextDoor[3] = map.PosVal(x, y - 1);
                if (nextDoor[0] == EntityTypes.Empty)
                {
                    return true;
                }
                if (nextDoor[1] == EntityTypes.Empty)
                {
                    return true;
                }
                if (nextDoor[2] == EntityTypes.Empty)
                {
                    return true;
                }
                if (nextDoor[3] == EntityTypes.Empty)
                {
                    return true;
                }
                break;

            case EntityTypes.ARanged:

                break;
        }


        return false;
    }
}