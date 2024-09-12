using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_midium : MonoBehaviour
{
    public int score = 0;
    public int limitscore = 20000;
    public GameObject chane, locked;

    public void Start()
    {
        chane = GameObject.Find("chane_mi");
        locked = GameObject.Find("lock_mi");

        // ScoreManagerのインスタンスを取得
        ScoreManager scoreManager = ScoreManager.Instance;
        /*if (scoreManager != null)
        {
            score = scoreManager.Score();
        }
        else
        {
            score = 0;
        }

        if (score >= limitscore)
        {
            Destroy(chane);
            Destroy(locked);
        }*/
        score = scoreManager.Score();
        Debug.Log(score);
        Destroy(locked);
        Destroy(chane);
    }

    public void change_button()
    {
        Debug.Log(score);
        if (score >= limitscore)
        {
            SceneManager.LoadScene("Medium");
        }
    }
}
