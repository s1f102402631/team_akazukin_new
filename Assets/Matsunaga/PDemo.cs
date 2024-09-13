using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//的の頭上にスコアを表示させるスクリプトです。
public class PDemo : MonoBehaviour
{
    [SerializeField]
    private GameObject PointObj; //Point
    [SerializeField]
    private GameObject PosObj; //的
    [SerializeField]
    private Vector3 AdjPos; //ダメージ表示の位置調整

    [SerializeField]
    private int Number; //ポイント数

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ViewPoint(Number);
        }
    }

    private void ViewPoint(int _damage)
    {
        string pointText = $"+{_damage}";
        GameObject _pointObj = Instantiate(PointObj); //プレハブをインスタンス化
        _pointObj.GetComponent<TextMesh>().text = pointText; //数値を入れる
        _pointObj.transform.position = PosObj.transform.position + AdjPos; //ダメージ表示オブジェクトの位置を設定
    }
}
