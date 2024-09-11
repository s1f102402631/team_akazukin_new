using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_midium : MonoBehaviour
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
        Debug.Log(score);
        if (score >= limitscore)
        {
            SceneManager.LoadScene("Midium");//secondを呼び出します
        }

    }
}
