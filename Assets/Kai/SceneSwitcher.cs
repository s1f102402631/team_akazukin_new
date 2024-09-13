using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    // 遷移先のシーン名を指定します
    private string nextSceneName = "Top scene";
    
    // 一時停止メニューのUIパネルを指定します
    public GameObject pauseMenu;

    // ゲームが一時停止中かどうかを判断するフラグ
    private bool isPaused = false;

    void Update()
    {
        // スペースキーが押されたかどうかをチェック
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 指定したシーン名に遷移します
            SceneManager.LoadScene(nextSceneName);
        }

        // エンターキーが押されたかどうかをチェック
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (isPaused)
            {
                // 一時停止を解除
                ResumeGame();
            }
            else
            {
                // ゲームを一時停止
                PauseGame();
            }
        }
    }

    private void PauseGame()
    {
        // 時間を停止
        Time.timeScale = 0;
        // 一時停止メニューを表示
        pauseMenu.SetActive(true);
        isPaused = true;
    }

    private void ResumeGame()
    {
        // 時間を再開
        Time.timeScale = 1;
        // 一時停止メニューを非表示
        pauseMenu.SetActive(false);
        isPaused = false;
    }
}