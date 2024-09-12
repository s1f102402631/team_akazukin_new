using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public GameObject ObjPlayer;
    public PlayerCtrl ScrPlayer;
    public GameObject ObjBulletGenerator;
    public BulletGen ScrBulletGenerator;
    public GameObject ObjRangeWall;
    public RangeWallCtrl ScrRangeWall;
    public GameObject ObjScoreManager;
    public ScoreManager ScrScoreManager;


    public int FrameRate = 60;
    public float ScrollSpeed = 0.1f;
    public int TimeLimit = 60;
    public int FrameLimit;
    public int StartCount = 3;
    public bool DoScroll = true;
    public int Tick = 0;
    bool FlagStart = false;

    private Coroutine IdCountdown;
    private Coroutine IdScroll;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = FrameRate;

        FrameLimit = TimeLimit * FrameRate;
        /*
        int StartTime = StartCount * FrameRate;
        int FinishTime = StartCount * FrameRate + FrameLimit;
        */

        ObjPlayer = GameObject.Find("Player");
        ScrPlayer = ObjPlayer.GetComponent<PlayerCtrl>();
        ObjBulletGenerator = GameObject.Find("BulletGenerator");
        ScrBulletGenerator = ObjBulletGenerator.GetComponent<BulletGen>();
        ObjRangeWall = GameObject.Find("RangeWall");
        ScrRangeWall = ObjRangeWall.GetComponent<RangeWallCtrl>();
        ObjScoreManager = GameObject.Find("ScoreManager");
        ScrScoreManager = ObjScoreManager.GetComponent<ScoreManager>();

        Transform TraPlayer = ObjPlayer.GetComponent<Transform>();
        Vector3 PlayerPos = TraPlayer.position;
        ScrBulletGenerator.MoveTo(0.0f, PlayerPos.y + 0.5f, PlayerPos.z + 1.0f);
        ScrRangeWall.MoveTo(0.0f, 0.0f, PlayerPos.z + 20.0f);

        FlagStart = false;
        Tick = 0;
        IdCountdown = StartCoroutine("CountDown");

        //StartCoroutine("Scroll");

        /*
        Debug.Log(Player);
        Vector3 test_pos = Player.GetComponent<PlayerCtrl>().GetPlayerPos();
        Debug.Log(test_pos.z);
        */
    }

    private IEnumerator CountDown()
    {
        for (int count = 0; count <= StartCount; count += 1)
        {
            if (count != StartCount)
            {
                Debug.Log(StartCount - count);
            } else {
                Debug.Log("Start!!!");
                ScrBulletGenerator.CanFire = true;
            }
            yield return new WaitForSeconds(1.0f);
        }
        //Debug.Log("test");
        FlagStart = true;
        yield break;
    }

    /*
    private IEnumerator Scroll()
    {
        for (int count = 0; count < 600/*FrameLimit*//*; count += 1)
        {
            ScrBulletGenerator.MoveZ(ScrollSpeed);
            ScrPlayer.MoveZ(ScrollSpeed);
            ScrRangeWall.MoveZ(ScrollSpeed);
            yield return new WaitForSeconds(0.017f/*1.0f / FrameRate*//*);
        }
        Debug.Log("Finish!!!");
        yield break;
    }
    */

    public void Scroll()
    {
        ScrBulletGenerator.MoveZ(ScrollSpeed);
        ScrPlayer.MoveZ(ScrollSpeed);
        ScrRangeWall.MoveZ(ScrollSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (! DoScroll){return;}
        if (! FlagStart){return;}
        if (Tick >= 6000){return;}

        Tick = Tick + 1;

        if (Tick == FrameLimit)
        {
            ScrBulletGenerator.CanFire = false;
            Debug.Log("Finsh!!!");
            FlagStart = false;
            ScrScoreManager.DisplayScore();
            SceneManager.LoadScene("StageSelect");
        }
        if (Tick >= FrameLimit){return;}

        Scroll();

        /*
        ScrBulletGenerator.MoveZ(ScrollSpeed);
        ScrPlayer.MoveZ(ScrollSpeed);
        ScrRangeWall.MoveZ(ScrollSpeed);
        */
    }
}