using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AimController_Z : MonoBehaviour
{
    public Vector3 targetPos;
    public Image aimImage;

    void Start()
    {
        // ゲーム開始時にカーソルを非表示にする
        Cursor.visible = false;
    }

    void Update()
    {
        // 「マウスの位置」と「照準器の位置」を同期させる。
        transform.position = Input.mousePosition;

        RaycastHit hit;

        // MainCameraからマウスの位置にRayを飛ばす
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            // RayがColliderと衝突した地点の座標を取得
            //targetPos = hit.point;
            //print(targetPos);

            /* タグが「Item」の場合、照準器を黄色に変化させる。
            if (hit.transform.CompareTag("Item"))
            {
                 aimImage.color = new Color(1.0f, 1.0f, 0.0f, 1.0f); // 黄色
             }
             else if (hit.transform.CompareTag("Enemy"))
             {
                 aimImage.color = new Color(1.0f, 0.0f, 0.0f, 1.0f); // 赤色
             }
             else
             {
                 // 照準器の色は白
                 aimImage.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
             }

            // 今後使用する色を新しく指定（デフォルトの色を白に設定）*/
            aimImage.color = new Color(1.0f, 1.0f, 1.0f, 1.0f); // デフォルトの色を白に設定

        }
        else
        {
            // Rayが何にも当たらない場合、照準器の色は白
            aimImage.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
    }
}