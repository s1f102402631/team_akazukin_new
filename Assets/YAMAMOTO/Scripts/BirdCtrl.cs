using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCtrl : MonoBehaviour
{
    public GameObject ObjScoreManager;
    public ScoreManager ScrScoreManager;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "BulletPrefab(Clone)")
        {
            Destroy(this.gameObject, 0.0f);
            ScrScoreManager.PlusScore("Bird");
            ScrScoreManager.DebugScore();
        }
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
}
