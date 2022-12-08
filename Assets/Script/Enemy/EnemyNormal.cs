using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNormal : Enemy2
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            DoDamage();
        }
    }



    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
    }
}
