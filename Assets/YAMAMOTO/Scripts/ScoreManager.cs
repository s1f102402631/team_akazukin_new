using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    public static int TotalScore = 0;
    public GameObject ObjScoreDisplay;
    public ScoreDisplayCtrl SrcScoreDisplay;

    public Dictionary<string, int> TagetScore = new Dictionary<string, int>(){
        {"Wolf", 200},
        {"Apple", 200},
        {"Bird", 500},
        {"Rabbit", 1000}
    };

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetScore(int num)
    {
        TotalScore = num;
    }

    public void PlusScore(string Target)
    {
        int Score = TagetScore[Target];
        TotalScore += Score;
    }

    public void MinusScore(string Target)
    {
        int Score = TagetScore[Target];
        TotalScore -= Score;
    }

    public void DebugScore()
    {
        Debug.Log(TotalScore);
    }

    public int Score()
    {
        return TotalScore;
    }

    public void DisplayScore()
    {
        string text = "スコア：" + TotalScore + "点";
        Debug.Log(text);
        SrcScoreDisplay.Display(text);
    }

    void Start()
    {
        ObjScoreDisplay = GameObject.Find("ScoreDisplay");
        SrcScoreDisplay = ObjScoreDisplay.GetComponent<ScoreDisplayCtrl>();

        TotalScore = 0;
    }

    void Update()
    {

    }
}