using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOOM : MonoBehaviour
{
    //新增一個空物件叫enemy(敵人)
    public GameObject enemy;
 

    //創造引用變量
    Vector3 b; //敵人方向
    Vector3 c; //敵人方向
    void Start()
    {
        //綁定引用變量
        Vector3 b = new Vector3(0, 0, 0);//敵人方向

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 c = GameObject.Find("Player").transform.position;//每秒偵測玩家位置
        

        if (Input.GetKeyDown(KeyCode.Space))//每當按下空白鍵
        {                                               
            Instantiate(enemy,c, Quaternion.Euler(b)); //生成語句Instantiate(物件名稱, 物件位置, 物件方向);
            Debug.Log(c);
        }
            
    }
}
