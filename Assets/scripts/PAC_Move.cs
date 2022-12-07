using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAC_Move : MonoBehaviour
{
   public Vector3 moveDir = new Vector3(0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        Move();
    }

    void Move()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = moveDir;
    }

    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveDir = new Vector3(0, 1, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            moveDir = new Vector3(0, -1, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            moveDir = new Vector3(-1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            moveDir = new Vector3(1, 0, 0);
        }
    }
}
