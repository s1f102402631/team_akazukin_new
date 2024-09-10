using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public GameObject ObjPlayer;
    public PlayerCtrl ScrPlayer;
    public GameObject ObjBulletGenerator;
    public BulletGen ScrBulletGenerator;
    public GameObject ObjRangeWall;
    public RangeWallCtrl ScrRangeWall;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

        ObjPlayer = GameObject.Find("Player");
        ScrPlayer = ObjPlayer.GetComponent<PlayerCtrl>();
        ObjBulletGenerator = GameObject.Find("BulletGenerator");
        ScrBulletGenerator = ObjBulletGenerator.GetComponent<BulletGen>();
        ObjRangeWall = GameObject.Find("RangeWall");
        ScrRangeWall = ObjRangeWall.GetComponent<RangeWallCtrl>();

        /*
        Debug.Log(Player);
        Vector3 test_pos = Player.GetComponent<PlayerCtrl>().GetPlayerPos();
        Debug.Log(test_pos.z);
        */
    }

    public float ScrollSpeed = 0.01f;
    // Update is called once per frame
    void Update()
    {
        
        ScrBulletGenerator.MoveZ(ScrollSpeed);
        ScrPlayer.MoveZ(ScrollSpeed);
        ScrRangeWall.MoveZ(ScrollSpeed);
        
    }
}