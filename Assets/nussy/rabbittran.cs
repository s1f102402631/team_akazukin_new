using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabbittran : MonoBehaviour
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
                if (frameCount <= 15)
                {
                    transform.position += new Vector3(0.2f, 0, 0);
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
                if (frameCount >= 26)
                {
                    // 停止終了、移動フェーズへ
                    isMoving = true;
                    frameCount = 0;
                }
            }
        }
    }
}
