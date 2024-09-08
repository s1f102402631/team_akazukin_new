using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGen : MonoBehaviour
{
    public GameObject BulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Bullet = Instantiate(BulletPrefab);
            //Bullet.GetComponent<BulletCtrl>().Shoot(new Vector3(0, 200, 2000));
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Bullet.GetComponent<BulletCtrl>().Shoot(ray.direction * 2000);
        }
    }
}
