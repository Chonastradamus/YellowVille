using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Ewolf : EnemiesDamage
{
    public event Action<bool> Detection = delegate { };
    EWolfView _view;
    public Renderer rendererwolf;
    public Material[] Materials;


    private void Start()
    {
        // _view = new(rendererwolf, Materials,this);
        _view = new EWolfView().SetRenderer(rendererwolf).SetArrayMaterials(Materials).SetControler(this);
    }
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        Detection(IsInChaseRange);
        
      
    }

    protected override void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }


}
