using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadPoint_Owl : MonoBehaviour
{
    [SerializeField]
    private GameObject PointObj; //Point
    
    private Vector3 AdjPos = new Vector3(0, 1, 0); //ダメージ表示の位置調整

    private int Number = 500; //ポイント数

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    /*

    // ゲームオブジェクトが破壊されたときに呼ばれる
    private void OnDestroy()
    {
        
        ViewPoint(Number);
    }
    */

    // ゲームオブジェクトが他の物体に当たった時に呼ばれる
    void OnCollisionEnter(Collision collision)
    {
        ViewPoint(Number);
    }


    private void ViewPoint(int _damage)
    {
        
        string pointText = $"+{_damage}";
        GameObject _pointObj = Instantiate(PointObj); //プレハブをインスタンス化
        _pointObj.GetComponent<TextMesh>().text = pointText; //数値を入れる
        _pointObj.transform.position = this.transform.position + AdjPos; //ダメージ表示オブジェクトの位置を設定

    }
}
