using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBOOM2 : Enemy2
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player1.GetComponent<PlayerMove>().playerHP -= 40;

            Instantiate(enemtDied1, transform.position, Quaternion.identity);

            Destroy(gameObject, enemyDiedtime1);
        }
    }
}
