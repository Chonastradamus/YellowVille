using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_wizzard : EnemiesDamage
{

    // utilziar decorator para hacer el poder del mago aumente
    protected override void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }

}
