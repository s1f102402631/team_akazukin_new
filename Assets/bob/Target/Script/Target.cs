using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Target : MonoBehaviour
{
    public int score = 100;
    public string target_name = "dummy";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider t)
    {
        on_Destroyed(score, target_name);
        Destroy(this);
    }

    private void on_Destroyed(int score, string target_name)
    {
        
    }
}
