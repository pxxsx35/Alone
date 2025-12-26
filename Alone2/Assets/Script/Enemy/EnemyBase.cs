using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract  class EnemyBase : MonoBehaviour
{
    [SerializeField] protected GameObject player;
    [SerializeField] protected float distance;
    [SerializeField] protected float speed;
    [SerializeField] protected float size;

    protected Rigidbody2D rig;
    bool isAttack;

 

    private void Update()
    {
      
        if(CanSeePlayer())
        {
      
            MoveToPlayer();
            if(CanAttack())
            {
                isAttack = true;
                AttackPlayer();
            }
            
        }
    }


    protected virtual void MoveToPlayer()
    {
        if (isAttack) return;
        float direction = player.transform.position.x > transform.position.x ? 1 : -1;
        transform.localScale = new Vector2(direction * size, transform.localScale.y);
        rig.velocity = new Vector2(direction * speed, 0);

    }
    bool CanAttack()
    {
        
        return Vector2.Distance(transform.position, player.transform.position) < 2;

    }
    protected virtual void AttackPlayer()
    {
        
    }
    protected virtual bool CanSeePlayer()
    {
        return Vector2.Distance(transform.position, player.transform.position) < distance;
    }
}
