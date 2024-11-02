using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_midium : MonoBehaviour
{
    public int score = 0;
    public int limitscore = 0;
    public GameObject chane, locked;
    public scoreselect scoreselect;

    public void Start()
    {
        chane = GameObject.Find("chane_mi");
        locked = GameObject.Find("lock_mi");

        // ScoreManagerのインスタンスを取得
        ScoreManager scoreManager = ScoreManager.Instance;
        if (scoreManager != null)
        {
            score = scoreManager.Score();
        }
        else
        {
            score = 0;
        }

        if (score >= limitscore || scoreselect.returnselect() == "midium" || scoreselect.returnselect() == "hard")
        {
            Destroy(chane);
            Destroy(locked);
            Debug.Log(score);
        }
    }

    public void change_button()
    {
        Debug.Log(score);
        if (score >= limitscore || scoreselect.returnselect() == "midium" || scoreselect.returnselect() == "hard")
        {
            if (scoreselect.returnselect() == "midium")
            {
                scoreselect.selectmap("midium");
            }
            SceneManager.LoadScene("Medium");
        }
    }
}
