using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Controller
{
    public event Action<float, float> onMovement = delegate { };
    public event Action<float> OnJump = delegate { };

    public Action onUpdate;
    public Action onJump;

    private Model _model;
    public Controller(Model model) 
    {
        _model = model;
        onUpdate += Movement;
        onUpdate += Jump;
        onUpdate += Attack;
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

    }
}
