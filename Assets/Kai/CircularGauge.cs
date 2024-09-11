using UnityEngine;
using UnityEngine.UI;

public class CircularGauge : MonoBehaviour
{
    public Image gaugeBar; // ゲージバーのImageコンポーネント
    public float fillSpeed = 0.1f; // 塗りつぶすスピード

    private float targetFillAmount = 0f; // 目標のfill amount
    private float currentFillAmount = 0f; // 現在のfill amount

    void Start()
    {
        // ゲージを初期化
        currentFillAmount = 0f;
        gaugeBar.fillAmount = currentFillAmount;
    }

    void Update()
    {
        // 目標値に向けてfill amountをスムーズに変化させる
        currentFillAmount = Mathf.MoveTowards(currentFillAmount, targetFillAmount, fillSpeed * Time.deltaTime);
        gaugeBar.fillAmount = currentFillAmount;

        // 自動的に目標値を変更
        if (currentFillAmount >= 1f)
        {
            targetFillAmount = 0f; // 1に達したら0にリセット
        }
        else
        {
            targetFillAmount = 1f; // 塗りつぶしの目標値を1に設定
        }
    }
}