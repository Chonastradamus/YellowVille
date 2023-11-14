using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Controller
{

    public event Action<float, float> onMovement = delegate { };
    public event Action<float> OnJump = delegate { };
    public event Action<float> Onshoot = delegate { };
    public event Action<bool,bool> OnTotem = delegate { };

    public Action onUpdate;
    public Action onJump;
    public Action onshoot;

    public Action onTotem;

    private Model _model;

    public Controller(Model model) 
    {
        _model = model;
        onUpdate += Movement;
        onUpdate += Jump;
        onUpdate += Attack;
        onUpdate += Totem;


    }


    private void Movement()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        onMovement(vertical, horizontal);
    }

    private void Jump()
    {
        var Jump = Input.GetAxisRaw("Jump");
        OnJump(Jump);
    }

    private void Attack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
          var shoot = Input.GetAxisRaw("Fire1");
          Onshoot(shoot);          
        }
    }

    public void Totem()
    {
        var totem = Input.GetKeyDown(KeyCode.E);
        var destroy = Input.GetKeyDown(KeyCode.Q);

        OnTotem(totem,destroy);

    }
   
}
