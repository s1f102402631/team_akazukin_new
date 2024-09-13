using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;
using JetBrains.Annotations;

#if UNITY_EDITOR
[CustomEditor(typeof(Target))]
#endif

public class Wolf : Target
{
    public override void on_Start()
    {
        is_vurnerable = false;
    }

    public override void on_Damaged()
    {
        base.on_Damaged();
        if(!is_vurnerable)
        {
            is_vurnerable = true;
        }
    }
}