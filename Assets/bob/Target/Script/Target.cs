using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

abstract public class Target : MonoBehaviour
{
    public int score = 100;
    public string target_name = "dummy";
    public bool is_vurnerable;

    void OnTriggerEnter(Collider t)
    {
        if (t.gameObject.name == "BulletPrefab(Clone)")
        {
            on_Damaged();
        }
    }

    public virtual void on_Damaged()
    {
        if(is_vurnerable)
        {
            Destroy(this);
        }
    }
}
