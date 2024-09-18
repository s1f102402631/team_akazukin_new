using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;
using JetBrains.Annotations;
using UnityEditor.UI;
using System.Runtime.CompilerServices;

#if UNITY_EDITOR
[CustomEditor(typeof(Target))]
#endif

public class Wolf : Target
{
    [SerializeField] private Animator animator;
    public int speed;
    private void Start()
    {
        score = 200;
        name = "wolf";

        is_vurnerable = false;
        speed = 4;
    }

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    public override void on_Damaged()
    {
        base.on_Damaged();
        if(!is_vurnerable)
        {
            is_vurnerable = true;
            speed = 1;
            transform.Rotate(0, 180, 0);
            animator.SetBool("Caught_Wolf", true);
        }
    }

    private void OnDestroy()
    {

    }
}