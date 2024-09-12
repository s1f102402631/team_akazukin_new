using UnityEngine;
using TMPro; // TextMeshProを使用

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI countdownText; // TextMeshProUGUIオブジェクトへの参照
    public float countdownTime = 3f; // カウントダウンの時間（秒）
    public float startMessageDuration = 0.5f; // "START!"メッセージを表示する時間（秒）

    private void Start()
    {
        StartCoroutine(Countdown());
    }

    private System.Collections.IEnumerator Countdown()
    {
        while (countdownTime > 0)
        {
            string timeString = Mathf.Ceil(countdownTime).ToString(); // 残り時間を文字列に

            // 一文字ごとに色を変えるロジック
            countdownText.text = GetColoredString(timeString);
            
            countdownTime -= Time.deltaTime; // 時間を減少させる
            yield return null; // 次のフレームまで待機
        }

        // カウントダウンが終了したときの処理
        countdownText.text = "START!"; // "START!"を表示
        yield return new WaitForSeconds(startMessageDuration); // メッセージ表示を待機
        countdownText.text = ""; // テキストを消す
    }

    private string GetColoredString(string input)
    {
        System.Text.StringBuilder coloredString = new System.Text.StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            // 色を変えるロジック（例: インデックスに基づいて色を変える）
            Color color = Color.Lerp(Color.yellow, Color.green, (float)i / input.Length);
            coloredString.Append($"<color=#{ColorUtility.ToHtmlStringRGB(color)}>{input[i]}</color>");
        }

        return coloredString.ToString();
    }
}