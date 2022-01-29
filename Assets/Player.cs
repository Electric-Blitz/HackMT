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

public void MovementDown()      //Down uses it
    {
        transform.position += new Vector3(0.0f, 0.0f, -2.0f);
    }

    public void MovementUp()     //Up uses it
    {
        transform.position += new Vector3(0.0f, 0.0f, 2.0f);
    }

    public void MovementRight()        //Right uses it
    {
        transform.position += new Vector3(2.0f, 0.0f, 0.0f);
    }

    public void MovementLeft()      //Left uses it
    {
        transform.position += new Vector3(-2.0f, 0.0f, 0.0f);
    }

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

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
