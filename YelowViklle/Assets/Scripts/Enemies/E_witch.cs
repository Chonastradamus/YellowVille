using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_witch : Enemies_Shoot
{
    protected override void OnDrawGizmos()
    {
            Gizmos.color = Color.magenta;
            Gizmos.DrawWireSphere(transform.position, checkRadius);      
    }
}
