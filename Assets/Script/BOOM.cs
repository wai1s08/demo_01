using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOOM : MonoBehaviour
{
    //�s�W�@�ӪŪ���senemy(�ĤH)
    public GameObject enemy;
 

    //�гy�ޥ��ܶq
    Vector3 b; //�ĤH��V
    Vector3 c; //�ĤH��V
    void Start()
    {
        //�j�w�ޥ��ܶq
        Vector3 b = new Vector3(0, 0, 0);//�ĤH��V

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 c = GameObject.Find("Player").transform.position;//�C�������a��m
        

        if (Input.GetKeyDown(KeyCode.Space))//�C����U�ť���
        {                                               
            Instantiate(enemy,c, Quaternion.Euler(b)); //�ͦ��y�yInstantiate(����W��, �����m, �����V);
            Debug.Log(c);
        }
            
    }
}
