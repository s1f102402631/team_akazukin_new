using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField]
    private GameObject PointObj; //Point

    private Vector3 AdjPos = new Vector3(0, 2.5f, 5); //ダメージ表示の位置調整

    private int _damage = 500; //ポイント数

    public GameObject ObjScoreManager;
    public ScoreManager ScrScoreManager;
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
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Wolf")
        {
            ScrScoreManager.PlusScore("Damage");
            ScrScoreManager.DebugScore();
            string pointText = $"-{_damage}";
            GameObject _pointObj = Instantiate(PointObj); //プレハブをインスタンス化
            _pointObj.GetComponent<TextMesh>().text = pointText; //数値を入れる
            _pointObj.transform.position = this.transform.position + AdjPos; //ダメージ表示オブジェクトの位置を設定

        }
    }
}
