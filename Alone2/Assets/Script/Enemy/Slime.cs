using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : EnemyBase
{
    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        distance = Random.Range(20, 30);
        speed = 10;
        player = GameObject.FindGameObjectWithTag("Player");
        size = 20;
    }

    // Update is called once per frame
    protected override bool CanSeePlayer()
    {
        return Vector3.Distance(transform.position, player.transform.position) < distance;
    }
}
