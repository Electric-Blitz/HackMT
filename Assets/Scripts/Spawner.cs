using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Map map;
    bool[,] O = new bool[50,50];

    public void BuildHouse()
    {

    }

    public void BuildStockpile()
    {

    }

    public void BuildTower()
    {
        
    }

    public void BuildPlayer()
    {
        for (int i = 0; i < 49; i++)
        {
            for (int j = 0; j < 49; j++)
            {
                O[i,j] = true;

                if (map.PosVal(i, j) != EntityTypes.Empty)
                    O[i,j] = false;
                                                                        //Checks for houses
                if (!(Next2House(i,j)))
                    O[i, j] = false;
            }
        }         
    }

    private bool Next2House(int i, int j)
    {
        return (map.PosVal(i - 1, j) == EntityTypes.AHouse || map.PosVal(i, j - 1) == EntityTypes.AHouse || map.PosVal(i + 1, j) == EntityTypes.AHouse || map.PosVal(i, j + 1) == EntityTypes.AHouse);
    }

    //public void BuildEnemy()





    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
