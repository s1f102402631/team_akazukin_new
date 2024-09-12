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
        try
        {
            score = scoreManager.Score();
        }
        catch { 
            score = 0;
        }
    }
    public void change_button() //change_button‚Æ‚¢‚¤–¼‘O‚É‚µ‚Ü‚·
    {
        Debug.Log(score);
        if (score >= limitscore)
        {
            SceneManager.LoadScene("Midium");//second‚ğŒÄ‚Ño‚µ‚Ü‚·
        }

    }
}
