using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edge : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wallup;//long and wide
    public GameObject walldown;
    public GameObject wallleft;
    public GameObject wallright;
    [Range(0,500)]
    public float walllong;
    [Range(0, 500)]
    public float widewide;

   public void wall()
    {
        wallup.transform.position = new Vector3(wallup.transform.position.x,walllong, wallup.transform.position.z);
        walldown.transform.position = new Vector3(wallup.transform.position.x, -walllong, wallup.transform.position.z);
        wallleft.transform.position = new Vector3(-widewide, wallup.transform.position.y, wallup.transform.position.z);
        wallright.transform.position = new Vector3(widewide, wallup.transform.position.y, wallup.transform.position.z);

    }

    private void OnValidate()//只在引擊中觸發，遊戲時不觸發
    {
        wall();
    }

}
