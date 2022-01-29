using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    bool[50, 50] O;

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

                if (PosVal(i, j) != Empty)
                    O[i,j] = false;
                                                                        //Checks for houses
                if (!(Next2House(i,j)))
                    O[i, j] = false;
            }
        }         
    }

    private bool Next2House(int i, int j)
    {
        return (PosVal(i - 1, j) == AHouse || PosVal(i, j - 1) == AHouse || PosVal(i + 1, j) == AHouse || PosVal(i, j + 1) == AHouse);
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
