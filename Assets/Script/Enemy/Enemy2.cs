using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy2 : MonoBehaviour
{
    public float chasingSpeed;//°l³v³t«×
    public float enemyDiedtime1;
    public GameObject enemtDied1;
    public Vector3 playerPos;
    public GameObject player1;


    public void DoDamage()
    {
        player1.GetComponent<PlayerMove>().playerHP -= 10;
       
        Instantiate(enemtDied1, transform.position, Quaternion.identity);

        Destroy(gameObject, enemyDiedtime1);
         
    }
 


    public void MoveToPlayer()
    {
        playerPos = GameObject.Find("Player").gameObject.transform.position;
        gameObject.transform.position = Vector3.MoveTowards(transform.position, playerPos, chasingSpeed*Time.deltaTime);
        chasingSpeed += Random.Range(0.001f,0.005f);

    }
}
