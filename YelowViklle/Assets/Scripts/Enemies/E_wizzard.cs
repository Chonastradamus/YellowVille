using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_wizzard : EnemiesDamage, Imagic
{
    Magic CurrentPower;
    public int Dmg;

    private void Start()
    {
        CurrentPower = new Crosier(CurrentPower);
       // CurrentPower = new FireMagic(CurrentPower);
      
      
    }
    

    protected override void Update()
    {
        Dmg = CurrentPower.Power();
        base.Update();
        print(Dmg);
       // Debug.Log(CurrentPower.Power());

    }

    public void AddMagic(Magic newmagic)
    {
        print("hechizero");
        CurrentPower = newmagic;
    }

    public Magic GetActualMagic()
    {
        return CurrentPower;
    }


    protected override void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }

}
