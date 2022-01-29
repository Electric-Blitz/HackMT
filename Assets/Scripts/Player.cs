using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public KeyCode up = KeyCode.W;
    public KeyCode down = KeyCode.S;
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;
    public GameObject player;
    public Map map;
    public Vector3 locale;

    public void MovementDown()      //Down uses it
    {
        if(map.moveCurPlayer(2) == true)
            transform.position += new Vector3(0.0f, 0.0f, -2.0f);
    }

    public void MovementUp()     //Up uses it
    {
        if (map.moveCurPlayer(8) == true)
            transform.position += new Vector3(0.0f, 0.0f, 2.0f);
    }

    public void MovementRight()        //Right uses it
    {
        if (map.moveCurPlayer(6) == true)
            transform.position += new Vector3(2.0f, 0.0f, 0.0f);
    }

    public void MovementLeft()      //Left uses it
    {
        if (map.moveCurPlayer(4) == true)
            transform.position += new Vector3(-2.0f, 0.0f, 0.0f);
    }

    public void PlayerLocale()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(up))
        {
            MovementUp();
        }
        if (Input.GetKeyDown(down))
        {
            MovementDown();
        }
        if (Input.GetKeyDown(left))
        {
            MovementLeft();
        }
        if (Input.GetKeyDown(right))
        {
            MovementRight();
        }


    }
}
