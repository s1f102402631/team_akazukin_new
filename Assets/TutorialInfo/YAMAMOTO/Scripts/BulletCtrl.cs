using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    public float DestroyTime = 0.0f;
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        //GetComponent<Rigidbody>().isKinematic = true;
        //GetComponent<ParticleSystem>().Play();
        Destroy(this.gameObject, DestroyTime);
    }

    //Start():読み込み時１回のみ実行される.
    void Start()
    {
        //Application.targetFrameRate = 60;
        //Shoot(new Vector3(0, 200, 2000));
    }

    //Update():フレームごとに一回実行される.
    void Update()
    {
        
    }
}
