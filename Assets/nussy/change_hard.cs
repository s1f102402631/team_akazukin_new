using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_hard : MonoBehaviour
{

    public ScoreManager scoreManager;
    private int score = 0;
    public int limitscore = 30000;
    public GameObject chane, locked;

    public void Start()
    {
        scoreManager = GetComponent<ScoreManager>();
        try
        {
            score = scoreManager.Score();
        }
        catch
        {
            score = 0;
        }
        chane = GameObject.Find("chane_ha");
        locked = GameObject.Find("lock_ha");
    }
    public void change_button() //change_button‚Æ‚¢‚¤–¼‘O‚É‚µ‚Ü‚·
    {
        Debug.Log(score);
        if (score >= limitscore)
        {
            SceneManager.LoadScene("Hard");//second‚ğŒÄ‚Ño‚µ‚Ü‚·
        }

    }
}