using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float enemyDiedtime1;
    public GameObject enemtDied1;
    public float chasingSpeed;//°l³v³t«×
    new Vector3 playerPos;

    private void OnTriggerEnter2D(Collider2D a)
    {
        a.gameObject.GetComponent<PlayerMove>().playerHP -= 10;
        Destroy(gameObject, enemyDiedtime1);
    }
 

    void OnDestroy()
    {
        Instantiate(enemtDied1, transform.position, Quaternion.identity);
    }

    private void Update()
    {
        playerPos = GameObject.Find("Player").gameObject.transform.position;
        gameObject.transform.position = Vector3.MoveTowards(transform.position, playerPos, chasingSpeed*Time.deltaTime);
        chasingSpeed += Random.Range(0.001f,0.005f);

    }
}
