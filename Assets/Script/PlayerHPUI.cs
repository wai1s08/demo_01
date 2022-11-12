using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPUI : MonoBehaviour
{
    int aHP = 100;
    public Text playerHPui;
    float time;
    public Text TimeUi;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        aHP = GameObject.Find("Player").GetComponent<PlayerMove>().playerHP;
        playerHPui.text = "HP:" + aHP;
        TimeUi.text = "time:" + time.ToString("#");

    }
}
