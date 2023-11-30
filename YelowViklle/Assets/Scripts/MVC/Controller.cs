using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Controller
{

    public event Action<float, float> onMovement = delegate { };
    public event Action<float> OnJump = delegate { };
    public event Action<float> Onshoot = delegate { };
    public event Action<bool> OnTotem = delegate { };
    public event Action<bool> OffTotem = delegate { };
    public event Action<bool> gamepaused = delegate { };

    bool pause = true;

    public Action onUpdate;
    public Action onJump;
    public Action onshoot;

    public Action TheTotem;

    private Model _model;

    public Controller(Model model) 
    {
        _model = model;
        onUpdate += Movement;
        onUpdate += Jump;
        onUpdate += Attack;
        onUpdate += onTotem;
        onUpdate += offTotem;
        onUpdate += ispause;

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

    public void onTotem()
    {
        var totem = Input.GetKeyDown(KeyCode.E);
        if (totem) { GameManager.instance.SaveManager(); }

        OnTotem(totem);

    }
    public void offTotem()
    {
        var totem = Input.GetKeyDown(KeyCode.Q);
        if (totem) { GameManager.instance.LoadManager(); }


        OffTotem(totem);

    }

    public void ispause()
    {
       

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (pause)
            {
                onUpdate -= Movement;
                onUpdate -= Jump;
                onUpdate -= Attack;
                onUpdate -= onTotem;
                onUpdate -= offTotem;
                pause = false;
                gamepaused(pause);
            }
            else if(!pause)
            {
                onUpdate += Movement;
                onUpdate += Jump;
                onUpdate += Attack;
                onUpdate += onTotem;
                onUpdate += offTotem;
                pause = true;
                gamepaused(pause);
            }
        }  
    }
}
