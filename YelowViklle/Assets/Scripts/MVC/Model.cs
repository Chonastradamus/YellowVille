using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour,Idamagable
{
    Controller controller;
    View _view;
    [SerializeField] Renderer _renderer;
    [SerializeField] float life;
    [SerializeField] float Speed;

    [SerializeField] bool OnGround;
    [SerializeField] float JumpForce;
    [SerializeField] LayerMask Ground;

    [Header("Factory_Objetcpool")]
    [SerializeField] public Bullet prefab;
    Factory<Bullet> _factory;
    ObjectPool<Bullet> _objectPool;
    public GameObject[] Firepoint;

    private void Awake()
    {
        OnGround = true;
    }
    void Start()
    {
        controller = new(this);
        controller.onMovement += Move;
        controller.OnJump += Jump;
        _view = new(_renderer, controller);

        controller.Onshoot += shoot;

        _factory = new BulletFactory(prefab);
        _objectPool = new ObjectPool<Bullet>(_factory.GetObj, Bullet.TurnOff, Bullet.TurnOn, 4);
    }

    void Update()
    {
        controller.onUpdate();
    }
    public void TakeDamage(float dmg)
    {
        life = -dmg;

            if (life <= 0)
            {
              this.gameObject.SetActive(false);
            }
        
    }

    public void Move(float horizontal, float vertical)
    {

        transform.position += new Vector3(horizontal, 0, vertical) * Speed * Time.deltaTime;
    }
    public void Jump(float Jump)
    {
       
        transform.position += new Vector3(0, Jump, 0) * JumpForce * Time.deltaTime;
        OnGround = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 6)
        {
            OnGround = true;
        }

    }

    public void shoot(float fire)
    {
            var bullet = _objectPool.Get();
            bullet.AddReference(_objectPool);
            bullet.transform.position = Firepoint[0].transform.position;
            bullet.transform.forward = Firepoint[0].transform.forward;  
    }


}
