using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject HHP;
    public GameObject rock;
    public int y;//�ͦ����Y�ƶq
    //�C�L�X��ͦ��@�Ӧ�]�A���򭺥��Ыب���ܶq���O�ΨӦs�x�ͦ����j�ɶ�
    public float spawnTime;//�ͦ��ɶ�
    float timeBetween; //�ɶ����j
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
        
        if(timeBetween>spawnTime)
        {
            SpawnObject(HHP);
            int emenyNuber = Random.Range(1, 3);
            if (emenyNuber == 1)
            {
                SpawnObject(Enemy1);
            }
            else if(emenyNuber ==2)
            {
                SpawnObject(Enemy2);
               
            }
            else if (emenyNuber == 3)
            {
                SpawnObject(Enemy3);
            }
            timeBetween = 0;
        }

        GameObject SpawnObject(GameObject Object_SP)
        {
           return Instantiate(Object_SP, new Vector3(Random.Range(wallRange.walllong, -wallRange.walllong), Random.Range(wallRange.widewide, -wallRange.widewide), 0), Quaternion.identity);
        }
    }
}
