using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_midium : MonoBehaviour
{

    public ScoreManager scoreManager;
    private int score = 0;
    public int limitscore = 20000;
    public GameObject chane, locked;
    

    public void Start()
    {
        chane = GameObject.Find("chane_mi");
        locked = GameObject.Find("lock_mi");
        scoreManager = GetComponent<ScoreManager>();
        try
        {
            score = scoreManager.Score();
        }
        catch { 
            score = 0;
        }
        if (score >= limitscore)
        {
            Destroy(chane);
            Destroy(locked);
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
