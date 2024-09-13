using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfCtrl : MonoBehaviour
{
    public GameObject ObjScoreManager;
    public ScoreManager ScrScoreManager;

    [SerializeField]
    private GameObject PointObj; //Point
    [SerializeField]
    private GameObject PosObj; //的
    [SerializeField]
    private Vector3 AdjPos; //ダメージ表示の位置調整

    private int Number = 200; //ポイント数

    void OnCollisionEnter(Collision collision)
    {
        ViewPoint(Number);
        Destroy(this.gameObject, 0.0f);
        ScrScoreManager.PlusScore("Wolf");
        ScrScoreManager.DebugScore();
    }

    // Start is called before the first frame update
    void Start()
    {
        ObjScoreManager = GameObject.Find("ScoreManager");
        ScrScoreManager = ObjScoreManager.GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ViewPoint(int _damage) //的の頭上にスコアを表示
    {
        string pointText = $"+{_damage}";
        GameObject _pointObj = Instantiate(PointObj); //プレハブをインスタンス化
        _pointObj.GetComponent<TextMesh>().text = pointText; //数値を入れる
        _pointObj.transform.position = PosObj.transform.position + AdjPos; //ダメージ表示オブジェクトの位置を設定
    }
}
