using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditViewController : MonoBehaviour
{
    public GameObject scrollView; // �X�N���[���r���[�I�u�W�F�N�g���Q�Ƃ��邽�߂̕ϐ�
    public GameObject creditView; // �N���W�b�g�r���[�I�u�W�F�N�g���Q�Ƃ��邽�߂̕ϐ�

    // �{�^�����N���b�N���ꂽ�Ƃ��ɌĂ΂�郁�\�b�h
    public void ToggleScrollView()
    {
        if (!scrollView.activeSelf)
        {
            // �X�N���[���r���[�̕\��/��\����؂�ւ���
            creditView.SetActive(!creditView.activeSelf);
        }
    }
}
