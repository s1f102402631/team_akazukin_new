using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Target : MonoBehaviour
{
    public int score = 100;
    public string target_name = "dummy";
    
    public bool is_vurnerable;
    // Start is called before the first frame update
    void Start()
    {
        on_Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void on_Start()
    {
        is_vurnerable = true;
    }

    void OnTriggerEnter(Collider t)
    {
        on_Damaged();
    }

    public virtual void on_Damaged()
    {
        if(is_vurnerable)
        {
            on_Destroyed(score, target_name);
        }
    }

    private void on_Destroyed(int score, string target_name)
    {
        //ここでスコア加算処理につながる関数をコールバック
        Destroy(this);
    }
}
