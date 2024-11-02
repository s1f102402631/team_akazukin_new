using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

#if UNITY_EDITOR
[CustomEditor(typeof(Target))]
#endif

public class Rabbit : Target
{
    public int speed;
    private void Start()
    {
        score = 100;
        name = "rabbit";
        is_vurnerable = true;
        speed = 2;
    }

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    public override void on_Damaged()
    {
        base.on_Damaged();
    }

    private void OnDestroy()
    {

    }
}