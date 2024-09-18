using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;
using JetBrains.Annotations;

#if UNITY_EDITOR
[CustomEditor(typeof(Target))]
#endif

public class Owl : Target
{
    public int speed;
    public int rotate_speed;
    private void Start()
    {
        score = 120;
        name = "owl";
        is_vurnerable = true;
        speed = 4;
        rotate_speed = 1;
    }

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        //transform.Rotate(new Vector3(0,-0.3f,0)); 
    }

    public override void on_Damaged()
    {
        base.on_Damaged();
    }

    private void OnDestroy()
    {

    }
}