using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip CountDownSE; //カウントダウン時のSE
    public AudioClip BGM; //ゲームプレイ中のBGM

    //ゲームプレイ中と結果発表の画面でAudioSourceをわけます。結果発表のSEはaudioSourceFinishに直接格納してあります。
    public AudioSource audioSourcePlay;
    public AudioSource audioSourceFinish;

    // Start is called before the first frame update
    void Start()
    {
        audioSourcePlay.PlayOneShot(CountDownSE); 
    }

    // Update is called once per frame
    void Update()
    {
        /*
        GameSystem Gamesystem = GetComponent<GameSystem>();

        if(Gamesystem.FlagStart)
        {
            audioSourcePlay.PlayOneShot(BGM);  
        }

        if(Gamesystem.Tick == Gamesystem.FrameLimit)
        {
            audioSourcePlay.Stop();
            audioSourceFinish.Play();
        }
        */

    }


}
