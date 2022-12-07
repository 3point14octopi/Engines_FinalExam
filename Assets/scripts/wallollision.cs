using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PAC_Move>())
        {
            other.GetComponent<PAC_Move>().moveDir = new Vector3(0, 0, 0);
        }
        
    }
}
