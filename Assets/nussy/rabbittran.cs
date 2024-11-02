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
                // 20�t���[���Ԉړ�
                if (frameCount <= 15)
                {
                    transform.position += new Vector3(0.2f, 0, 0);
                }
                else
                {
                    // �ړ��I���A��~�t�F�[�Y��
                    isMoving = false;
                    frameCount = 0;
                }
            }
            else
            {
                // 30�t���[���Ԓ�~
                if (frameCount >= 26)
                {
                    // ��~�I���A�ړ��t�F�[�Y��
                    isMoving = true;
                    frameCount = 0;
                }
            }
        }
    }
}
