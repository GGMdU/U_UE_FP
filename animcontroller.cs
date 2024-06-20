using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animcontroller : MonoBehaviour
{
    PlayerMove pm;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.Find("Player");
        anim = GetComponent<Animator>();
        if (obj != null)
        {
            pm = obj.GetComponent<PlayerMove>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if(pm.dir != Vector3.zero)
        {
            anim.SetBool("forward",true);
        }
        else
        {
            anim.SetBool("forward",false);
        }
        if(pm.ground != true)
        {
            anim.SetBool("falling",true);
        }
        else
        {
            anim.SetBool("falling",false);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("jump");
        }

    }
}
