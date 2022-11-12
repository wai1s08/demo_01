using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public Vector3 PlayerInput;
    Animator anim;
    float noInputTime;
    public int playerHP = 100;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        
    }   
    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("noInput", noInputTime);
        if (noInputTime<2)
        {
            noInputTime += Time.deltaTime;
        }
        PlayerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
      
            if (PlayerInput != Vector3.zero)
            {
                anim.SetBool("isRun", true);
                transform.position += (PlayerInput * speed * Time.deltaTime);
                noInputTime = 0;
            }
            else
            {
                anim.SetBool("isRun", false);
            }
           
    }

}