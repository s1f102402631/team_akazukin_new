using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeWallCtrl : MonoBehaviour
{
    public void Move(float x, float y, float z)
    {
        transform.Translate(x, y, z);
    }
    
    public void MoveZ(float z)
    {
        transform.Translate(0, 0, z);
    }

    public void MoveTo(float x, float y, float z)
    {
        transform.position = new Vector3(x, y, z);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
