using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBOOM1 : Enemy2
{
    public float atime;//�l��Ǫ��ɶ����j
    public Spawner Spawner;

    private void Start()
    {
        Spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
        player1 = GameObject.Find("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            player1.GetComponent<PlayerMove>().playerHP += 10;

            Instantiate(enemtDied1, transform.position, Quaternion.identity);

            Destroy(gameObject, enemyDiedtime1);
        }
    }
    void Update()
    {
        atime += Time.deltaTime;
        if (atime> 3) //�l��Ǫ�
        {
            Instantiate(Spawner.Enemy1, transform.position, Quaternion.identity);
            atime = 0;
            
        }
    }
}
