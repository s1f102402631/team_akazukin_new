using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woltran : MonoBehaviour
{
    private bool isMoving = true;

    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == "Player")
        {

            if (isMoving)
            {
                // 20フレーム間移動
                transform.position += new Vector3(0, 0, -0.25f);


            }
        }
            if (other.name == "Wolfgab")
            {
                transform.position += new Vector3(0, 0.15f, 0f);
            }
        
    }
}
