
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewController : MonoBehaviour
{
    public GameObject scrollView; // スクロールビューオブジェクトを参照するための変数
    public GameObject creditView; // クレジットビューオブジェクトを参照するための変数

    // ボタンがクリックされたときに呼ばれるメソッド
    public void ToggleScrollView()
    {
        if (!creditView.activeSelf)
        {
            // スクロールビューの表示/非表示を切り替える
            scrollView.SetActive(!scrollView.activeSelf);
        }
    }
}