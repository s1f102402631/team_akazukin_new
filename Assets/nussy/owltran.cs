using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class owltran : MonoBehaviour
{
    private int frameCount = 0;
    private bool isMoving = true;

    void OnTriggerStay(Collider other)
    {
        if (other.name == "Player")
        {
            frameCount++;

            if (isMoving)
            {
                // 20フレーム間移動
                if (frameCount <= 40)
                {
                    transform.position += new Vector3(0, 0.05f, 0);
                }
                else
                {
                    // 移動終了、停止フェーズへ
                    isMoving = false;
                    frameCount = 0;
                }
            }
            else
            {
                // 30フレーム間停止
                if (frameCount <= 60)
                {
                    Debug.Log("a");
                    transform.position += new Vector3(0, -0.033f, 0);
                }
                else
                {
                    // 停止終了、移動フェーズへ
                    isMoving = true;
                    frameCount = 0;
                }
            }
        }
    }
}
