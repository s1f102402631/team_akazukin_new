using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource audioSourcePlay; //ゲームプレイ中BGM
    public AudioSource audioSourceFinish; //結果発表のSE

    private GameSystem GameSystem;

    int Tick;
    int FrameLimit;

    public bool GameFin; //ゲームが終了したときtrueになる

    // Start is called before the first frame update
    void Start()
    {
        GameSystem = GetComponent<GameSystem>();
        GameFin = false;
    }

    // Update is called once per frame
    void Update()
    {
        FrameLimit = GameSystem.FrameLimit;
        Tick = GameSystem.Tick;

        if (Tick == FrameLimit & (!GameFin))
        {
            GameFin = true;

            audioSourcePlay.Stop(); 
            audioSourceFinish.Play();   
        }

    }


}
