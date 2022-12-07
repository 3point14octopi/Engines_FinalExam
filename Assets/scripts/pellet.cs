using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//command pattern
using PCommand;




public class pellet : MonoBehaviour
{
    PelletCommand pCom;
    // Start is called before the first frame update
    void Start()
    {

        pCom = new PelletCommand(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PAC_Move>())
        {
            PManager.instance.EatPellet(pCom);
        }
        
    }
}
