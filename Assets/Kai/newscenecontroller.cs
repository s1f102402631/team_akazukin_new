using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // UIを使用するために必要

public class newscenecontroller : MonoBehaviour
{
    // ボタンをインスペクターで設定するための変数
    public Button yourButton;

    void Start()
    {
        // ボタンがクリックされたときにLoadSceneメソッドを呼び出す
        if (yourButton != null)
        {
            yourButton.onClick.AddListener(LoadScene);
        }
    }

    void LoadScene()
    {
        // Gameシーンを読み込む
        SceneManager.LoadScene("Easy");
    }
}
