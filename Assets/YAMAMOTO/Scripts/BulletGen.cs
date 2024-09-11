using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGen : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform TraBulletGen;

    public bool CanFire = false;

    public void Move(float x, float y, float z)
    {
        transform.Translate(x, y, z);
    }
    
    public void MoveZ(float z)
    {
        transform.Translate(0, 0, z);
    }

    public void MoveTo(float x, float y, float z)
    {
        transform.position = new Vector3(x, y, z);
    }

    // Start is called before the first frame update
    void Start()
    {
        //Application.targetFrameRate = 60;
        TraBulletGen = transform;

        CanFire = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (! CanFire){return;}
            
            GameObject Bullet = Instantiate(BulletPrefab, TraBulletGen);
            //Bullet.GetComponent<BulletCtrl>().Shoot(new Vector3(0, 200, 2000));
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Bullet.GetComponent<BulletCtrl>().Shoot(ray.direction * 2000);
        }
    }
}
