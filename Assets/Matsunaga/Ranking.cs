using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_WEBGL
using unityroom.Api;
#endif

public class Ranking : MonoBehaviour
{   
    [SerializeField]
    public int BordNum;
    private Music Music;
    private ScoreManager ScoreManager;
    public GameObject ScoreManagerObj;

    bool FirstGamefin; //ゲームが終了状態になった瞬間を判定
    int LastScore; //最終的なスコア
    // Start is called before the first frame update
    void Start()
    {
        FirstGamefin = false;
        LastScore =  0;

        Music = GetComponent<Music>();
        ScoreManagerObj = GameObject.Find("ScoreManager");
    }

    // Update is called once per frame
    void Update()
    {
        if(Music.GameFin & (!FirstGamefin))
        {
            FirstGamefin = true;

            //スコアマネージャーからスコアを取得
            ScoreManager = ScoreManagerObj.GetComponent<ScoreManager>();
            LastScore = ScoreManager.TotalScore;

            //Unityroomに転送
            // ボードNo(BordNum)にスコアLastScoreを送信する。
            Debug.Log(LastScore);
            #if UNITY_WEBGL
            UnityroomApiClient.Instance.SendScore(BordNum, LastScore, ScoreboardWriteMode.HighScoreDesc);
            #endif

        }
        
    }
}
