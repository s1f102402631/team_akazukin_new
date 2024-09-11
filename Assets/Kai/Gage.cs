using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gage : MonoBehaviour
{
    [SerializeField] Slider gage;
    public float startIncreaseTime; //ゲージの自然回復の開始時間
    public float maxGageValue; //ゲージの最大値
    public float GageIncreaseTime; //ゲージの回復速度
    public float gageDecreaseValue; //ゲージを減らす量
    public float gageIncreaseValue; //ゲージの回復量

    float currentGageValue; //現在のゲージの値

    private float gageIncreaseTime; //ゲージ自然回復開始時間までの経過時間
    private float timeBetweenIncrease; //ゲージの回復速度を格納する変数

    void Start()
    {
        gage.maxValue = maxGageValue;
        gage.value = maxGageValue;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && currentGageValue > 0)
        {
            gageIncreaseTime = 0f;
            currentGageValue-=gageDecreaseValue;
            gage.value = currentGageValue;
        }

        gageIncreaseTime += Time.deltaTime;

        //設定された回復開始時間に達していてかつゲージの現在値が最大値より少ない場合は回復をする
        if (gageIncreaseTime > startIncreaseTime && currentGageValue < maxGageValue)
        {
            timeBetweenIncrease += Time.deltaTime;

            //1秒間隔でゲージを回復する
            if (timeBetweenIncrease >= GageIncreaseTime)
            {
                timeBetweenIncrease = 0f;
                currentGageValue += gageIncreaseValue;
                gage.value = currentGageValue;
            }
        }
    }
}

