using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_wizzard : EnemiesDamage
{
    Magic CurrentPower;


    private void Start()
    {
        CurrentPower = new Crosier("long sword");
        CurrentPower = new ICeMagic(CurrentPower);
        CurrentPower = new FireMagic(CurrentPower);
        CurrentPower = new ICeMagic(CurrentPower);
        CurrentPower = new ICeMagic(CurrentPower);
        CurrentPower = new ICeMagic(CurrentPower);
        CurrentPower = new ICeMagic(CurrentPower);
        
        Debug.Log(CurrentPower.GetDescrition() + " " + CurrentPower.Power());

    }
    // utilziar decorator para hacer el poder del mago aumente

    protected override void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }

}
