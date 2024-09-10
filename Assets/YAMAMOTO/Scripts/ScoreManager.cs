using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int TotalScore = 0;
    //public int SubScore = 0;
    public Dictionary<string, int> TagetScore = new Dictionary<string, int>(){
        {"Wolf", 200},
        {"Apple", 200},
        {"Bird", 500},
        {"Rabbit", 1000}
    };

    void SetScore(int num)
    {
        TotalScore = num;
    }

    void PlusScore(string Target)
    {
        int Score = TagetScore[Target];
        TotalScore = TotalScore + Score;
    }

    void MinusScore(string Target)
    {
        int Score = TagetScore[Target];
        TotalScore = TotalScore - Score;
    }

    void DebugScore()
    {
        Debug.Log(TotalScore);
    }

    int Score()
    {
        return TotalScore;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
