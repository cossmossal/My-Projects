using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public bool isAttacking;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.layer == 7 && isAttacking == true)
        {
           AudioManagerScript.PlaySound("PlayerHIT");
            Destroy(other.gameObject);
       }
        
    }

    
}
