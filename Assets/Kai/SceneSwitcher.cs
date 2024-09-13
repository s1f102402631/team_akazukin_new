using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // 遷移先のシーン名を指定します。シーン名を "Top scene" に変更
    private string nextSceneName = "Top scene";

    void Update()
    {
        // スペースキーが押されたかどうかをチェック
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 指定したシーン名に遷移します
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
