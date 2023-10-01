using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public  abstract class Enemies_Behavior : MonoBehaviour,Idamagable
{
    //tp1 Juan Guastini
    [Header("Movement")]
    [SerializeField] Rigidbody _rb;
    [Header("Detecction")]
    [SerializeField] public float checkRadius;
    public LayerMask whatIsPlayer;
    public Transform[] target;
    [SerializeField] public bool IsInChaseRange;
    [Header("Life")]
    public float life;
    [SerializeField] Idamagable idamagable;


    private void Awake()
    {
        life = FlyweightPointer.enemies.Maxlife;
    }
    protected virtual void Update()
    {
       detection();
    }

    public void detection()
    {
        IsInChaseRange = Physics.CheckSphere(transform.position, checkRadius, whatIsPlayer);
    }


    protected virtual void FixedUpdate()
    {
        if (IsInChaseRange)
        {
            MoveEnemies();
        }
    }

    void MoveEnemies()
    {

        transform.Translate(Vector3.forward * FlyweightPointer.enemies.speed * Time.deltaTime);
        Vector3 direction = target[0].position - transform.position;
        direction.y = 0; // Para evitar movimientos verticales
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.1f);
    }

    public void TakeDamage(int dmg)
    {
       life -= dmg;


        if (life <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    protected virtual void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }



}
