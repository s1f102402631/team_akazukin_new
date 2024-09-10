using UnityEngine;
using UnityEngine.UI;

public class ScrollViewController2 : MonoBehaviour
{
    public GameObject scrollView;  // ScrollViewのGameObject
    public Button closeButton; // CloseButtonのButtonコンポーネント

    void Start()
    {
        // 最初にScrollViewを非表示にする場合は以下の行をコメントアウト
        // scrollView.SetActive(false);

        if (closeButton != null)
        {
            closeButton.onClick.AddListener(CloseScrollView);
        }
    }

    // ScrollViewを閉じる関数
    void CloseScrollView()
    {
        scrollView.SetActive(false);
    }

    // ScrollViewを表示する関数-他のボタンのクリックイベントで呼び出す
    public void OpenScrollView()
    {
        scrollView.SetActive(true);
    }
}