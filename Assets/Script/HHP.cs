using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HHP : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D b)
    {
        if(b.tag =="Player")
        {
            b.gameObject.GetComponent<PlayerMove>().playerHP += 10;
            Destroy(gameObject);
        }
        
    }
}
