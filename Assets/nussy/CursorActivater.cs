using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorActivater : MonoBehaviour
{
    public bool isActivate = true;

    void Start()
    {
        Cursor.visible = isActivate;
    }

}
