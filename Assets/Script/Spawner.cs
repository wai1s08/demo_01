using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject HHP;
    public GameObject rock;
    public int y;//生成石頭數量
    //每過幾秒生成一個血包，那麼首先創建兩個變量分別用來存儲生成間隔時間
    public float spawnTime;//生成時間
    float timeBetween; //時間間隔
    public edge wallRange;

    // Start is called before the first frame update
    void Start()
    {
        for (int x=0; x < y; x++)
        {
            Instantiate(rock,new Vector3(Random.Range(40,-40), Random.Range(40,-40),0),Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        timeBetween += Time.deltaTime;
        if(timeBetween>spawnTime   )
        {
            SpawnObject(Enemy);
            SpawnObject(HHP);
            timeBetween = 0;
        }

        GameObject SpawnObject(GameObject Object_SP)
        {
           return Instantiate(Object_SP, new Vector3(Random.Range(wallRange.walllong, -wallRange.walllong), Random.Range(wallRange.widewide, -wallRange.widewide), 0), Quaternion.identity);
        }
    }
}
