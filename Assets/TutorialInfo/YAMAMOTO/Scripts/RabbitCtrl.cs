using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitCtrl : MonoBehaviour
{
    public GameObject ObjScoreManager;
    public ScoreManager ScrScoreManager;

    void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject, 0.0f);
        ScrScoreManager.PlusScore("Rabbit");
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
}
