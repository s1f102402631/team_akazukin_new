using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Unity�G���W���̃V�[���Ǘ��v���O�����𗘗p����

public class change_easy : MonoBehaviour //change�Ƃ������O�ɂ��܂�

{
    public ScoreManager scoreManager;
    private int score = 0;
    public int limitscore = 20000;

    public void Start()
    {
        scoreManager = GetComponent<ScoreManager>();
        score = scoreManager.Score();
    }
    public void change_button() //change_button�Ƃ������O�ɂ��܂�
    {
        if (score >= limitscore)
        {
            SceneManager.LoadScene("Easy");//second���Ăяo���܂�
        }

    }
}