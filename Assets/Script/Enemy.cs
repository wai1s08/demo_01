using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemyDiedtime;
    public GameObject enemtDied;
  

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, enemyDiedtime);

    }
    void OnDestroy()
    {
        Instantiate(enemtDied, transform.position, Quaternion.identity);
    }

    
}
