using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_wizzard : EnemiesDamage
{
    Magic CurrentPower;
    public float Dmg;

    private void Start()
    {
        CurrentPower = new Crosier("Wood Ceoiser");
        CurrentPower = new ICeMagic(CurrentPower);
        CurrentPower = new FireMagic(CurrentPower);
        CurrentPower = new ICeMagic(CurrentPower);
        CurrentPower = new ICeMagic(CurrentPower);
        CurrentPower = new ICeMagic(CurrentPower);
        CurrentPower = new ICeMagic(CurrentPower);

        Debug.Log(CurrentPower.GetDescrition() + " " + CurrentPower.Power());
        Dmg += FlyweightPointer.enemies.Damage;
        Dmg += CurrentPower.Power();
    }
    // utilziar decorator para hacer el poder del mago aumente

    protected override void Update()
    {
        base.Update();
        print(Dmg);

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Fire")
        {
            print("pepe");
            CurrentPower = CurrentPower.Add();
        }
    }

    protected override void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }

}
