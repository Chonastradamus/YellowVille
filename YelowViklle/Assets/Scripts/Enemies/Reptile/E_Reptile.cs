using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Reptile : EnemiesDamage
{
    // hacer un enemigo que cuando pierda vid y llegue a ciert cantidad utilize la habilidad de volver a su lugar



    protected override void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }


}
