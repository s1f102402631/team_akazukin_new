using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditViewController : MonoBehaviour
{
    public GameObject scrollView; // スクロールビューオブジェクトを参照するための変数
    public GameObject creditView; // クレジットビューオブジェクトを参照するための変数

    // ボタンがクリックされたときに呼ばれるメソッド
    public void ToggleScrollView()
    {
        if (!scrollView.activeSelf)
        {
            // スクロールビューの表示/非表示を切り替える
            creditView.SetActive(!creditView.activeSelf);
        }
    }
}
