using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Unityエンジンのシーン管理プログラムを利用する

public class change_easy : MonoBehaviour //changeという名前にします

{
    public ScoreManager scoreManager;
    private int score = 0;
    public int limitscore = 20000;

    public void Start()
    {
        scoreManager = GetComponent<ScoreManager>();
        score = scoreManager.Score();
    }
    public void change_button() //change_buttonという名前にします
    {
        if (score >= limitscore)
        {
            SceneManager.LoadScene("Easy");//secondを呼び出します
        }

    }
}