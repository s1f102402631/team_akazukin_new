using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointNum : MonoBehaviour
{
    
    [SerializeField]
    private float DeleteTime = 1.0f; //消えるまでの時間
    [SerializeField]
    private float MoveRange = 1.0f; //消えるまでの時間どれだけ上に上げるか
    [SerializeField]
    private float EndAlpha = 0; //消えるときの透明度

    private float TimeCnt;
    private TextMesh NowText;

    // Start is called before the first frame update
    void Start()
    {
        TimeCnt = 0.0f;
        Destroy(this.gameObject, DeleteTime); //数値の表示をDeleteTime秒後消す
        NowText = this.gameObject.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(Camera.main.transform); //数字が常にカメラを向くようにする
        TimeCnt += Time.deltaTime; //経過時間カウント
        this.gameObject.transform.localPosition += new Vector3(0, MoveRange / DeleteTime * Time.deltaTime, 0); //数値を上に上げる
        this.gameObject.transform.Rotate(0, -180.0f, 0);
        float _alpha = 1.0f - (1.0f - EndAlpha) * (TimeCnt / DeleteTime); //経過時間によって透明度を変更
        if (_alpha <= 0.0f) _alpha = 0.0f; //透明度の最小値を設定
        NowText.color = new Color(NowText.color.r, NowText.color.g, NowText.color.b, _alpha); //透明度を反映
    }

    
}
