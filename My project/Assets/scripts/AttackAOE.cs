using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAOE : MonoBehaviour
{
    public Collider attack;
    public bool alreadyAttacked;
    public float cooldown;
    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && cooldown < 0.1)
        {
            Instantiate(attack, transform.position, transform.rotation) ;
            alreadyAttacked = true;
            
        }

        if(alreadyAttacked == true)
        {

        }
    }
}
