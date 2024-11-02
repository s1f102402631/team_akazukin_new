using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_hard : MonoBehaviour
{
    public int score = 0;
    public int limitscore = 30000;
    public GameObject chane, locked;
    public scoreselect scoreselect;

    public void Start()
    {
        chane = GameObject.Find("chane_ha");
        locked = GameObject.Find("lock_ha");

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

        if (score >= limitscore)
        {
            Destroy(chane);
            Destroy(locked);
            Debug.Log(score);
        }
    }

    public void change_button()
    {
        Debug.Log(score);
        if (score >= limitscore || scoreselect.returnselect() == "hard")
        {
            scoreselect.selectmap("hard");
            SceneManager.LoadScene("Hard");
        }
    }

}
